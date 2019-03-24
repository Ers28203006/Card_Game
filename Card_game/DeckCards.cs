using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class DeckCards
    {
        private List<Card<string>> cards;
        private List<string> rankCard;
        private List<string> suitCard;
        public Dictionary<int, string> superiorityRank;

        public DeckCards()
        {
            cards = new List<Card<string>>();
            rankCard = new List<string>() { "6", "7", "8", "9", "10", "В", "Д", "К", "Т" };
            suitCard = new List<string>() { "П", "Ч", "К", "Б" };
            superiorityRank = new Dictionary<int, string> (rankCard.Count);

            for (int i = 0; i < rankCard.Count; i++)
            {
                superiorityRank.Add(i, rankCard[i]);
            }

            for (int i = 0; i < rankCard.Count; i++)
            {
                for (int j = 0; j < suitCard.Count; j++)
                {
                    cards.Add(new Card<string>(rankCard[i], suitCard[j]));
                }
            }

        }

        public int GetCountCards()
        {
            return cards.Count;
        }

        public void ShowDeckCard()
        {
            foreach (var card in cards)
            {
                Console.Write(card.Rank + card.Suit + " ");
            }
            Console.WriteLine();
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = cards.Count; i > 1; i--)
            {
                int j = rnd.Next(i);
                cards.Add(cards[j]);
                cards.RemoveAt(j);
            }
        }

        public void Distribution(ref List<Player> players, int countPlayers)
        {
            // var countCardPlayers = cards.Count() / countPlayers;

            for (int i = 0; i < countPlayers; i++)
            {
                players.Add(new Player(cards[i]));
                cards.RemoveAt(i);
            }
        }

    }
}
