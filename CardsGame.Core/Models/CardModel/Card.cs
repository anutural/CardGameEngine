using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.Core.Models.CardModel
{
    internal class Card : ICard
    {
        #region Private Member Variables
        readonly CardType _type;
        readonly CardRank _rank;
        #endregion
        #region Public Properties
        public CardType Type
        {
            get { return this._type; }
        }
        public CardRank Rank
        {
            get { return this._rank; }
        }
        public bool IsPower
        {
            get { return this._type == CardCommons.PowerCard; }
        }
        public int Points
        {
            get { return getPoint(); }
        }
        #endregion

        internal Card (CardType type, CardRank rank)
        {
            this._type = type;
            this._rank = rank;
        }

        #region  Private Methods
        private int getPoint()
        {
            int point = 0;

            if (this._rank == CardRank.Five)
                return 5;
            else if (this._rank >= CardRank.Ten)
                return 10;
            else if (this._type == CardType.Spades && this._rank == CardRank.Three)
                return 30;

            return point;
        }
        #endregion
    }
}
