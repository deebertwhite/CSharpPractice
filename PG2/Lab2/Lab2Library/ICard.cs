using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Library
{
    public enum CardSuit
    {
        Spades = 0,
        Hearts = 1,
        Clubs = 2,
        Diamonds = 3
    }
    public enum CardFace
    {
        Ace = 0,
        Two,
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
        King
    }
    public interface ICard
    {
        CardSuit Suit { get; }
        CardFace Face { get; }
        void Draw(int x, int y);

    }
}
