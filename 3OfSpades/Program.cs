using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardsGame.Core.Models.GameModel;
using CardsGame.Core.Factories.GameFactory;
using CardsGame.Core.Models.PlayerModel;
using CardsGame.Core.Models.CardModel;

namespace CardsGame
{
    class Program
    {
        static IGame game;
        static IPlayer player1;
        static IPlayer player2;
        static IPlayer player3;
        static IPlayer player4;
        static void Main(string[] args)
        {
            game = GameFactory.GetGame(GameEnum._3OfSpades, 4);
            game.RegisterPlayer("amit", out player1);
            game.RegisterPlayer("kartik", out player2);
            game.RegisterPlayer("priyank", out player3);
            game.RegisterPlayer("mohit", out player4);
            game.Start();
            PlayerThread();
            Console.Read();
        }

        static void PlayerThread()
        {
            //while(game.GetGameStatus() != GameStatus.Ended)
            {
                Console.WriteLine(String.Format("{0,18}|{1,18}|{2,18}|{3,18}|",
                   player1.Name, player2.Name, player3.Name, player4.Name));
                for (int i = 0; i < player1.Cards.Count; i++)
                {
                    Console.WriteLine(String.Format("{0,18}|{1,18}|{2,18}|{3,18}|",
                        String.Format("{0,6} of {1,8}", player1.Cards[i].Rank, player1.Cards[i].Type),
                        String.Format("{0,6} of {1,8}", player2.Cards[i].Rank,player2.Cards[i].Type),
                        String.Format("{0,6} of {1,8}", player3.Cards[i].Rank, player3.Cards[i].Type),
                        String.Format("{0,6} of {1,8}", player4.Cards[i].Rank, player4.Cards[i].Type)));
                }
            }
        }
    }
}
