using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.Core.Models.CardModel
{
    public enum CardType
    {
        Spades,
        Hearts,
        Clubs,
        Diamond
    }
    public enum CardRank
    {
        Tow,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public interface ICard
    {
        CardType Type { get; }
        CardRank Rank { get; }
        bool IsPower { get; }
        int Points { get; }

    }
}
