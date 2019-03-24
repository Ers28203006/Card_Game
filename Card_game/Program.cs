using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class CardTable
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Запрос колоды карт (нажмите любую кнопку): ");
            Console.ReadLine();

            DeckCards deckCards = new DeckCards();
            deckCards.ShowDeckCard();

            Console.WriteLine("Нажмите любую кнопку для тасования колоды карт");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Растосованая колода карт: ");
            deckCards.Shuffle();
            deckCards.ShowDeckCard();

            Console.WriteLine("Нажмите любую кнопку для выводы информации о количестве игроков");
            Console.ReadLine();
            Console.Clear();

            Console.Write("\nKоличество игроков: ");
            Random random = new Random();
            int countPlayers = random.Next(2, 10);
            Console.WriteLine(countPlayers);

            Console.WriteLine("Нажмите любую кнопку для раздачи карт игрокам");
            Console.ReadLine();
            Console.Clear();

            List<Player> players = new List<Player>();
            Console.WriteLine("\nРаздача карт игрокам...");
            deckCards.Distribution(ref players, countPlayers);
            ShowPlayers(players, countPlayers);

            Console.WriteLine("Нажмите любую кнопку для определения, очередности ходов");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nРаспределение ходов игрокам:");
            DistributionMoves(players);
            ShowPlayers(players, countPlayers);

            GameVictory(players);
           
            Console.ReadLine();
        }
        static void GameVictory(List<Player> players)
        {
            int rankCard = 9;

            for (int j = 0; j < rankCard; j++)
            {
                if (j == 0)
                {
                    int cnt = 0;
                    foreach (var player in players)
                    {
                        ++cnt;
                        if (player.cardsPlayer.Rank == "Т")
                        {
                            Console.WriteLine("выиграл игрок {0}", cnt);
                            j = rankCard;
                            break;
                        }
                    }
                }

                else if (j == 1)
                {
                    int cnt = 0;
                    foreach (var player in players)
                    {
                        ++cnt;
                        if (player.cardsPlayer.Rank == "К")
                        {
                            Console.WriteLine("выиграл игрок {0}", cnt);
                            j = rankCard;
                            break;
                        }
                    }
                }
                else if (j == 2)
                {
                    int cnt = 0;
                    foreach (var player in players)
                    {
                        ++cnt;
                        if (player.cardsPlayer.Rank == "Д")
                        {
                            Console.WriteLine("выиграл игрок {0}", cnt);
                            j = rankCard;
                            break;
                        }
                    }
                }
                else if (j == 3)
                {
                    int cnt = 0;
                    foreach (var player in players)
                    {
                        ++cnt;
                        if (player.cardsPlayer.Rank == "В")
                        {
                            Console.WriteLine("выиграл игрок {0}", cnt);
                            j = rankCard;
                            break;
                        }
                    }
                }
                else if (j == 4)
                {
                    int cnt = 0;
                    foreach (var player in players)
                    {
                        ++cnt;
                        if (player.cardsPlayer.Rank == "10")
                        {
                            Console.WriteLine("выиграл игрок {0}", cnt);
                            j = rankCard;
                            break;
                        }
                    }
                }
                else if (j == 5)
                {
                    int cnt = 0;
                    foreach (var player in players)
                    {
                        ++cnt;
                        if (player.cardsPlayer.Rank == "9")
                        {
                            Console.WriteLine("выиграл игрок {0}", cnt);
                            j = rankCard;
                            break;
                        }
                    }
                }
                else if (j == 6)
                {
                    int cnt = 0;
                    foreach (var player in players)
                    {
                        ++cnt;
                        if (player.cardsPlayer.Rank == "8")
                        {
                            Console.WriteLine("выиграл игрок {0}", cnt);
                            j = rankCard;
                            break;
                        }
                    }
                }
                else if (j == 7)
                {
                    int cnt = 0;
                    foreach (var player in players)
                    {
                        ++cnt;
                        if (player.cardsPlayer.Rank == "7")
                        {
                            Console.WriteLine("выиграл игрок {0}", cnt);
                            j = rankCard;
                            break;
                        }
                    }
                }
                else if (j == 8)
                {
                    int cnt = 0;
                    foreach (var player in players)
                    {
                        ++cnt;
                        if (player.cardsPlayer.Rank == "6")
                        {
                            Console.WriteLine("выиграл игрок {0}", cnt);
                            j = rankCard;
                            break;
                        }
                    }
                }
            }
        }

        static void ShowPlayers(List<Player> players, int countPlayers)
        {
            for (int i = 0; i < countPlayers; i++)
            {
                Console.Write("{0}-й игрок: ", i + 1);
                players[i].ShowCardPlayers();
                Console.WriteLine();
            }
        }

        static void DistributionMoves(List<Player> players)
        {
            Random rnd = new Random();
            for (int i = players.Count; i > 1; i--)
            {
                int j = rnd.Next(i);
                players.Add(players[j]);
                players.RemoveAt(j);
            }
        }
    }
}