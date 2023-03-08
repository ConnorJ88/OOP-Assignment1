using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMP1903M_A01_2223;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> pack;

        public Pack()
        {
            //Creates new list of Cards
            pack = new List<Card>();
            {
                Pack deck = new Pack();
                for (int suitIndex = 0; suitIndex < 4; suitIndex++)
                {
                    for (int cardNumberIndex = 0; cardNumberIndex < 13; cardNumberIndex++)
                    {
                        pack.Add(new Card((CardValue)cardNumberIndex, (Suits)suitIndex));
                    }
                }

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
                for (int length = 52; length > 0; length--)
                {
                    int x = random.Next(0, length + 1);
                    (pack.pack[x], pack.pack[length]) = (pack.pack[length], pack.pack[x]);

                }
                pack.pack = shuffledPack;
                return true;

            }
            else if (typeOfShuffle == 2)
            {
                Pack pack = new Pack();
                Random randomSide = new Random();
                Random randomAmount = new Random();
                int x = randomAmount.Next(2, 24);
                for (int y = 0; x < 24; x++)
                {
                    int midpoint = pack.pack.Count / 2;
                    List<Card> topHalf = pack.pack.GetRange(0, midpoint);
                    List<Card> bottomHalf = pack.pack.GetRange(midpoint, midpoint);
                    List<Card> shuffledPack = new List<Card>();
                    int decision = randomSide.Next(1, 2);
                    if (decision == 1)
                    {
                        for (int i = 0; i < midpoint; i++)
                        {
                            shuffledPack.Add(topHalf[i]);
                            shuffledPack.Add(bottomHalf[i]);
                        }
                    }
                    else if (decision == 2)
                    {
                        for (int i = 0; i < midpoint; i++)
                        {
                            shuffledPack.Add(bottomHalf[i]);
                            shuffledPack.Add(topHalf[i]);
                        }
                    }
                    pack.pack = shuffledPack;


                }

                return true;
            }
            else if (typeOfShuffle == 3)
            {
                Pack pack = new Pack();
                deal(pack.pack);
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
            Console.WriteLine("You have been dealt" + deal);
        }
        public static List<Card> dealCard(int amount, List<Card> list)
        {
            var deal = list.Take(amount);
            foreach (Card card in deal)
            {
                Console.WriteLine("You have been dealt" + deal);
            }

            //Deals the number of cards specified by 'amount'

        }
    }
}
    






