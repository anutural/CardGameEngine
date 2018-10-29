using CardsGame.Core.Factories.CardFactory;
using CardsGame.Core.Factories.PlayerFactory;
using CardsGame.Core.Models.CardModel;
using CardsGame.Core.Models.PlayerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.Core.Models.GameModel
{
    internal class _3OfSpadesGame : IGame
    {
        private int MaxPlayerCount { get; set; }
        internal List<IPlayer> Players { get; set; }
        internal IPlayer CurrentMasterPlayer { get; set; }
        internal List<IPlayer> PartnerPlayer { get; set; }
        internal List<IPlayer> CompetitorPlayer { get; set; }
        internal int BitPoints { get; set; }

        static internal IGame Instance { get; set; }

        private _3OfSpadesGame(){   }

        static internal IGame GetGameInstance()
        {
            if (_3OfSpadesGame.Instance != null)
                return _3OfSpadesGame.Instance;
            else
                return Instance = new _3OfSpadesGame();
        }

        public GameStatus GetGameStatus()
        {
            if (Players.Any(player => player.Cards.Count > 0))
                return GameStatus.Running;
            else
                return GameStatus.Ended;
        }

        public void CreateGame(int maxPlayerCount)
        {
            MaxPlayerCount = maxPlayerCount;
            Players = new List<IPlayer>(MaxPlayerCount);
        }

        public bool RegisterPlayer(string name, out IPlayer player)
        {
            player = PlayerFactory.GetPlayer(name);
            if (Players.Count() < MaxPlayerCount)
            {
                Players.Add(player);
                return true;
            }
            return false;
        }

        public bool Start()
        {
            return distributeCards();
        }

        private bool distributeCards()
        {
            List<ICard> deck = CardFactory.GetDeck();
            int count = 0;
            while (count < deck.Count)
            {
                for (int i = 0; i < Players.Count; i++)
                {
                    Players[i].Cards.Add(deck[count]);
                    count++;
                }
            }

            return Players.Select(player => player.Cards.Count).Distinct().Count() == 1;
        }
    }
}
