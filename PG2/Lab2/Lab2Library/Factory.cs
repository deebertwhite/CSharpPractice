using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Library
{
    public static class Factory
    {
        public static ICard CreateCard(CardSuit suit, CardFace face)
        {
            return new Card(suit, face);
        }

        public static ICard CreateBlackjackCard(CardSuit suit, CardFace face)
        {
            return new Card(suit, face);
        }
    }
}
