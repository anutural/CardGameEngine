using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.Core.Models.CardModel
{
    internal static class CardCommons
    {
        static CardType _powerCard;
        internal static CardType PowerCard
        {
            get { return _powerCard; }
            set { _powerCard = value; }
        }
    }
}
