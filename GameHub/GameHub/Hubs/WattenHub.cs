using Microsoft.AspNetCore.SignalR;
using GameHub.Models.Watten;
using GameHub.Extensions;

namespace GameHub.Hubs
{
    public class WattenHub : Hub
    {
        static Dictionary<string, Game> groups = new Dictionary<string, Game>();

        public async Task JoinGroup(string group)
        {
            if (groups.ContainsKey(group) && groups[group].playerDict.Count < 2)
            {
                groups[group].playerDict.Add(Context.ConnectionId, new Player { Cards = new List<Card>()});
                await Clients.Client(Context.ConnectionId).SendAsync("GetInitialCards", groups[group].deck.Cards.Skip(5).Take(5).ToList());
                await Clients.Client(GetOtherPlayer(group)).SendAsync("TurnChange");
                await Clients.Client(GetOtherPlayer(group)).SendAsync("ChooseSchlag");
                
            }
            else if (!groups.ContainsKey(group))
            {
                groups.Add(group, new Game());
                groups[group].playerDict.Add(Context.ConnectionId, new Player { Cards = new List<Card>()});
                groups[group].deck.Cards.Shuffle();
                await Clients.Client(Context.ConnectionId).SendAsync("GetInitialCards", groups[group].deck.Cards.Take(5).ToList());
            }
        }

        public async Task PlayCard(Card card, string group)
        {
            await Clients.Client(GetOtherPlayer(group)).SendAsync("EnemyPlayedCard", card);

            Card cardWithValue = CalculateCardValue(card, group);
            groups[group].playedCards.Add(Context.ConnectionId, cardWithValue);
            if (groups[group].playedCards.Count >= 2)
            {
                if(groups[group].playedCards.FirstOrDefault().Value.points < cardWithValue.points)
                {
                    Player winningPlayer = groups[group].playerDict[Context.ConnectionId];
                    winningPlayer.stiche += 1;
                    await Clients.Client(Context.ConnectionId).SendAsync("YouGetStich");
                    await Clients.Client(GetOtherPlayer(group)).SendAsync("EnemyGetStich");
                    if (winningPlayer.stiche >= 3)
                    {
                        await Clients.Client(Context.ConnectionId).SendAsync("YouWon");
                        await Clients.Client(GetOtherPlayer(group)).SendAsync("YouLost");
                    }
                }
                else
                {
                    Player winningPlayer = groups[group].playerDict[GetOtherPlayer(group)];
                    winningPlayer.stiche += 1;
                    await Clients.Client(GetOtherPlayer(group)).SendAsync("YouGetStich");
                    await Clients.Client(Context.ConnectionId).SendAsync("EnemyGetStich");

                    if (winningPlayer.stiche >= 3)
                    {
                        await Clients.Client(GetOtherPlayer(group)).SendAsync("YouWon");
                        await Clients.Client(Context.ConnectionId).SendAsync("YouLost");
                    }
                }
                groups[group].playedCards.Clear();
            }
        }

        private Card CalculateCardValue(Card card, string group)
        {
            if (card.Name.Contains(groups[group].farbe))
            {
                card.points = card.points * 3;
            }
            if (card.Name.Contains(groups[group].stich))
            {
                card.points = card.points * 8;
            }
            return card;
        }

        public async Task SubmitFarbe(string farbe, string group)
        {
            groups[group].farbe = farbe;
            await Clients.Client(GetOtherPlayer(group)).SendAsync("ChosenFarbe", farbe);
        }

        public async Task SubmitSchlag(string schlag, string group)
        {
            groups[group].stich = schlag;
            await Clients.Client(GetOtherPlayer(group)).SendAsync("ChooseFarbe", schlag).ConfigureAwait(false);
        }

        private string GetOtherPlayer(string group)
        {
            return groups[group].playerDict.Keys.First(p => !p.Equals(Context.ConnectionId));
        }
    }
}