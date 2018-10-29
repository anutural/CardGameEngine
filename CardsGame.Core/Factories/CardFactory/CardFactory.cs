using CardsGame.Core.Models.CardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.Core.Factories.CardFactory
{
    internal static class CardFactory
    {
        private static ICard GetCard(CardType type, CardRank rank)
        {
            return new Card(type, rank);
        }

        internal static List<ICard> GetDeck()
        {
            List<ICard> deck = new List<ICard>();

            foreach(CardType type in Enum.GetValues(typeof(CardType)))
            {
                foreach(CardRank rank in Enum.GetValues(typeof(CardRank)))
                {
                    deck.Add(GetCard(type, rank));
                }
            }

            return shuffle(deck);
        }

        private static List<ICard> shuffle(List<ICard> deck)
        {
            Random randomGenerator = new Random();
            Dictionary<int, ICard> cardMapTable = new Dictionary<int, ICard>();

            for (int i = 0; i < deck.Count; i++)
            {
                while (true)
                {
                    int newIndex = randomGenerator.Next(1, 53);
                    if(!cardMapTable.ContainsKey(newIndex))
                    {
                        cardMapTable.Add(newIndex, deck[i]);
                        break;
                    }
                }
            }

            return cardMapTable.OrderBy(x => x.Key).ToDictionary(y => y, y => y.Value).Values.ToList();
        }
    }
}
