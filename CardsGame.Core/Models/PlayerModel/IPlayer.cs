using CardsGame.Core.Models.CardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.Core.Models.PlayerModel
{
    public interface IPlayer
    {
        List<ICard> Cards { get; set; }
        string Name { get; set; }
    }
}
