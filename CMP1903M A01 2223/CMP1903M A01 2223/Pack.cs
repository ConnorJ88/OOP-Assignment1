using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
                deal(pack.pack);
                return true;
            }
            else if (typeOfShuffle == 2)
            {
                Pack pack = new Pack();               
                Random side = new Random();
                Random randomAmount = new Random();
                int x = randomAmount.Next(2, 24);
                for (int y = 0; y < x; y++)
                {
                    int midpoint = pack.pack.Count / 2;
                    List<Card> topHalf = pack.pack.GetRange(0, midpoint);
                    List<Card> bottomHalf = pack.pack.GetRange(midpoint, midpoint);
                    List<Card> shuffledPack = new List<Card>();
                    int decision = randomAmount.Next(1, 2);
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
                    deal(pack.pack);


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
            foreach (Card card in deal)
            {
                Console.WriteLine(card.Value + " of " + card.Suit);
            }
            return deal.First();
        }
        public static List<Card> dealCard(int amount, List<Card> list)
        {
            var deal = list.Take(amount);
            foreach (Card card in deal)
            {
                Console.WriteLine(card.Value + " of " + card.Suit);
            }
            return deal.ToList();
            //Deals the number of cards specified by 'amount'

        }
    }
}

    






