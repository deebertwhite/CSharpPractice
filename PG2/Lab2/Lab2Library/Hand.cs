using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Library
{
    public class Hand
    {
        protected static List<ICard> _Cards = new List<ICard>();

        public static void AddCard(ICard card)
        {
            _Cards.Add(card);
        }

        public static void Draw()
        {
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            int x = 0;
            int y = 0;
            foreach (Card card in _Cards)
            {
                if (x >= (width - 5))
                {
                    x = 0;
                    y += 2;
                }

                string thisCard = string.Empty;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                char club = '\u2663';
                char spade = '\u2660';
                char diamond = '\u2666';
                char heart = '\u2665';

                if (card.Suit == CardSuit.Clubs)
                {
                    card.Draw(x, y);
                    Console.WriteLine($" {club}     {card.Face} ");
                    x += 15;
                }
                if (card.Suit == CardSuit.Hearts)
                {
                    card.Draw(x, y);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" {heart}     {card.Face} ");
                    x += 15;
                }
                if (card.Suit == CardSuit.Diamonds)
                {
                    card.Draw(x, y);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" {diamond}     {card.Face} ");
                    x += 15;
                }
                if (card.Suit == CardSuit.Spades)
                {
                    card.Draw(x, y);
                    Console.WriteLine($" {spade}     {card.Face} ");
                    x += 15;
                }
                Console.ResetColor();
            }

        }
    }
}
