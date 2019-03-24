using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player
    {
        public Card<string> cardsPlayer;
        public Player(Card<string> cards)
        {
            cardsPlayer = cards;
        }

        public void ShowCardPlayers()
        {
            Console.WriteLine(cardsPlayer.Rank+cardsPlayer.Suit);
        }
    }
}
