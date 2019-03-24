using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card<T>
    {
        public T Rank { get; set; }
        public T Suit { get; set; }
        public Card(T rank, T suit)
        {
            Rank = rank;
            Suit = suit;
            
        }

    }
}
