using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CMP1903M_A01_2223;
using static CMP1903M_A01_2223.Card;

namespace CMP1903M_A01_2223
{
    class Pack
    {




        public List<Card> pack { get; set; }

        // Initialising the initial card pack

        public Pack()
        {
            pack = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                pack.Add(new Card(i));
            }
        }
    


        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            
            if (typeOfShuffle == 1)
            {
                Pack pack = new Pack();
                Random random = new Random();
                List<Card> shuffledPack = new List<Card>();
                for (int length = pack.pack.Count; length > 0; length--)

                {
                    int x = random.Next(length);
                    var temp = pack.pack[x];
                    shuffledPack.Add(temp);
                    pack.pack.RemoveAt(x);

                }
                pack.pack = shuffledPack;
                Console.WriteLine("How many Cards do you want?");
                string Input = Console.ReadLine();
                bool Valid = int.TryParse(Input, out int amount);
                if (Valid)
                {
                    if (amount == 1)
                    {
                        deal(pack.pack);
                    }

                    else if (2 <= amount)
                    {
                        dealCard(amount, pack.pack);

                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid Number");
                }
                return true;
            }
            else if (typeOfShuffle == 2)
            {
                Pack pack = new Pack();
                Random random = new Random();
                List<Card> shuffledPack = new List<Card>();
                int half = pack.pack.Count / 2;
                List<Card> firstHalf = new List<Card>();
                List<Card> secondHalf = new List<Card>();
                int count = 0;
                for (int i = 0; i <= 25; i ++)
                {
                    firstHalf.Add(pack.pack[i]);
                    secondHalf.Add(pack.pack[i]);
                    firstHalf[i] = pack.pack[i];
                    secondHalf[i] = pack.pack[i+26];
                }
                for (int i = 0; i <= 25; i = i + 1)
                {
                    shuffledPack.Add(firstHalf[count]);
                    shuffledPack.Add(secondHalf[count]);
                    count++;
                }

                Console.WriteLine("How many Cards do you want?");
                string Input = Console.ReadLine();
                bool Valid = int.TryParse(Input, out int amount);
                if (Valid)
                {
                    if (amount == 1)
                    {
                        deal(pack.pack);
                    }

                    else if (2 <= amount)
                    {
                        dealCard(amount, pack.pack);

                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid Number");
                }




                return true;
            }
            else if (typeOfShuffle == 3)
            {
                Pack pack = new Pack();
                Console.WriteLine("How many Cards do you want?");
                string Input = Console.ReadLine();
                bool Valid = int.TryParse(Input, out int amount);
                if (Valid)
                {
                    if (amount == 1)
                    {
                        deal(pack.pack);
                    }

                    else if (2 <= amount)
                    {
                        dealCard(amount, pack.pack);

                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid Number");
                }
                return true;

            }
            else
            {
                Console.Write("Please enter a valid option");
                return false;
            }



        }
        public static Card deal(List<Card> list)
        {
            //Deals one card
            var deal = list.Take(1);
            deal = list.Take(1);
            foreach (Card card in deal)
            {
                Console.WriteLine(Card.Display(card.Value, card.Suit));
            }
            Console.ReadLine();
            return deal.First();
        }
        public static List<Card> dealCard(int amount, List<Card> list)
        {
            var deal = list.Take(amount);
            foreach (Card card in deal)
            {
                Console.WriteLine(Card.Display(card.Value, card.Suit));
            }
            Console.ReadLine();
            return deal.ToList();
            //Deals the number of cards specified by 'amount'

        }
    }
}

    






