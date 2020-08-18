using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Library
{
    public class Deck
    {

        public List<ICard> _Cards = new List<ICard>();

        public void NewDeck()
        {
            foreach (CardFace i in Enum.GetValues(typeof(CardFace)))
            {
                _Cards.Add(Factory.CreateCard(CardSuit.Clubs, i));

                _Cards.Add(Factory.CreateCard(CardSuit.Hearts, i));

                _Cards.Add(Factory.CreateCard(CardSuit.Spades, i));

                _Cards.Add(Factory.CreateCard(CardSuit.Diamonds, i));
            }
        }

        public Deck()
        {
            NewDeck();
            Shuffle();
        }

        public ICard Deal()
        {
            if (_Cards.Count == 0)
            {
                NewDeck();
                Shuffle();
            }
            ICard card = _Cards[0];
            _Cards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            _Cards = _Cards.OrderBy(a => Guid.NewGuid()).ToList();
        }
    }
}   
