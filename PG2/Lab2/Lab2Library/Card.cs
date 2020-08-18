using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Library
{
    public class Card : ICard
    {
        public CardSuit Suit { get; private set; }

        public CardFace Face { get; private set; }

        public Card(CardSuit suit, CardFace face)
        {
            Suit = suit;
            Face = face;
        }

        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

    }
}
