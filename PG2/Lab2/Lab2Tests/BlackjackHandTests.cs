using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Library.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {
        [TestMethod()]
        public void AddCardTest()
        {
            BlackjackHand hand = new BlackjackHand();
            ICard card1 = Factory.CreateBlackjackCard(CardSuit.Hearts, CardFace.Ace);
            ICard card2 = Factory.CreateBlackjackCard(CardSuit.Hearts, CardFace.Eight);
            BlackjackHand.AddCard(card1);
            BlackjackHand.AddCard(card2);
            Console.WriteLine($"{BlackjackHand.Score}");
            Assert.AreEqual(19, BlackjackHand.Score);

            ICard card3 = Factory.CreateBlackjackCard(CardSuit.Hearts, CardFace.Ten);
            BlackjackHand.AddCard(card2);
            Console.WriteLine($"{BlackjackHand.Score}");
            Assert.AreEqual(19, BlackjackHand.Score);

        }
    }
}