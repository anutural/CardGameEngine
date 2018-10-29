using CardsGame.Core.Models.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.Core.Factories.GameFactory
{
    public class GameFactory
    {
        public static IGame GetGame(GameEnum gameType, int maxNumberOfPlayers)
        {
            IGame game;
            switch(gameType)
            {
                case GameEnum._3OfSpades:
                default:
                    game = _3OfSpadesGame.GetGameInstance();
                    break;
            }
            game.CreateGame(maxNumberOfPlayers);
            return game;
        }
    }

    
}
