using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Red7.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Card[] Palette { get; set; }


        public List<Card> SameNumbersList()
        {
            List<Card>[] cards = new List<Card>[8];
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = new List<Card>();
            }

            foreach (var card in Palette)
            {
                cards[card.Number].Add(card);
            }

            List<Card> result = new List<Card>();
            
            foreach (var list in cards)
            {
                if (list.Count >= result.Count)
                {
                    result = list;
                }
            }

            return result;
        }

        public Card HighestColor(List<Card> cardsList)
        {
            Card highestCard = null;

            foreach (var card in cardsList)
            {
                if (highestCard == null)
                {
                    highestCard = card;
                }
                else
                {
                    if (card.Color > highestCard.Color)
                    {
                        highestCard = card;
                    }
                }
            }
            return highestCard;
        }

    }


}
