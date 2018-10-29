using CardsGame.Core.Models.PlayerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.Core.Factories.PlayerFactory
{
    internal static class PlayerFactory
    {
        internal static IPlayer GetPlayer(string playerName)
        {
            return new Player(playerName);
        }
    }
}
