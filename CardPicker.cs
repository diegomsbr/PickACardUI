using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    public class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards) {
            string[] cards = new string[numberOfCards];

            for (int i=0; i < numberOfCards; i++) {
                string cardValue = RandomValue();
                string cardSuit = RandomSuit();
                cards[i] = $"{cardValue} of {cardSuit}";
            }
            return cards;
        }
        private static string RandomValue() {
            int value = random.Next(1, 14); 
            string cardValue = value switch
            {
                1 => "Ace",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => value.ToString()
            };
            return cardValue;
        }
        private static string RandomSuit() {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            int suitIndex = random.Next(0, suits.Length);
            string cardSuit = suits[suitIndex];
            return cardSuit;
        }
    }

}
