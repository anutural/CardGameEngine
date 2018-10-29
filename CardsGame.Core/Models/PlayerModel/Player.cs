using CardsGame.Core.Models.CardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.Core.Models.PlayerModel
{
    class Player : IPlayer
    {
        public string Name { get; set; }
        public List<ICard> Cards { get; set; }

        internal Player(string name)
        {
            this.Name = name;
            Cards = new List<ICard>();
        }
    }
}
