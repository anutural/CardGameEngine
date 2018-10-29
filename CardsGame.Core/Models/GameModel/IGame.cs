using CardsGame.Core.Models.PlayerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.Core.Models.GameModel
{
    public interface IGame
    {
        void CreateGame(int maxPlayerCount);
        bool RegisterPlayer(string name, out IPlayer player);
        GameStatus GetGameStatus();
        bool Start();
    }

    public enum GameEnum
    {
        _3OfSpades,
        Other
    }
    public enum GameStatus
    {
        Running,
        Ended
    }
}
