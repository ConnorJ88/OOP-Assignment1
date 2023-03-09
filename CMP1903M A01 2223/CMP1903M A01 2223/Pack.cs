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
    //Represesents Pack of Cards
    class Pack
    {




        public List<Card> pack { get; set; }

        // Initialising the initial card pack

        public Pack()
        {
            pack = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                pack.Add(new Card(i)); //Adds Cards individually until a total of 52
            }
        }


        //Shuffles the pack based on the type of shuffle
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            // Fisher Yates Shuffle           
            if (typeOfShuffle == 1)
            {
                Pack pack = new Pack(); //Ordered set of Cards
                Random random = new Random();
                List<Card> shuffledPack = new List<Card>(); //PAck to hold shuffled cards
                for (int length = pack.pack.Count; length > 0; length--)

                {
                    int x = random.Next(length); //generates random index to add to empty list
                    var temp = pack.pack[x];
                    shuffledPack.Add(temp);
                    pack.pack.RemoveAt(x);

                }
                pack.pack = shuffledPack;
                bool inRange = false;
                while (inRange != true)//loops until a number from 1 to 52 is entered
                {


                    Console.WriteLine("How many Cards do you want?");
                    string Input = Console.ReadLine();
                    bool Valid = int.TryParse(Input, out int amount); //Error handling if input can't be converted to int
                    if (Valid)
                    {
                        if (amount <= 52 && 1 <= amount) //compares amount entered to ensure it's within range
                        {
                            if (amount == 1)
                            {
                                deal(pack.pack); //if user inputs 1, it calls deal
                                inRange = true;
                                break;
                            }

                            else if (2 <= amount)
                            {
                                dealCard(amount, pack.pack); //if the user input is greater than 1, it calls deal card
                                inRange = true;
                                break;

                            }
                        }
                        else
                        {
                            Console.WriteLine("Please select a number from 1 to 52");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid Number");
                    }
                }
                return true;
            }
            // Riffle Shuffle
            else if (typeOfShuffle == 2)
            {
                Pack pack = new Pack(); 
                Random random = new Random();
                List<Card> shuffledPack = new List<Card>();
                //Generates two empty lists to store half of each cards
                List<Card> firstHalf = new List<Card>(); 
                List<Card> secondHalf = new List<Card>();
                //Adds first half of pack
                for (int i = 0; i <= 25; i ++)
                {
                   
                    firstHalf.Add(pack.pack[i]);
                    
                }
                //Second half of pack
                for (int i = 26; i <= 51; i++)
                {
                    secondHalf.Add(pack.pack[i]);
                }
                //Iterates between both lists until 52 are added (starts indexing at 0)
                for (int i = 0;i<= 25; i++) 
                {
                    shuffledPack.Add(firstHalf[i]);
                    shuffledPack.Add(secondHalf[i]);
                }
                pack.pack = shuffledPack;
                bool inRange = false;
                while (inRange != true)
                {


                    Console.WriteLine("How many Cards do you want?");
                    string Input = Console.ReadLine();
                    bool Valid = int.TryParse(Input, out int amount);
                    if (Valid)
                    {
                        if (amount <= 52 && 1 <= amount)
                        {
                            if (amount == 1)
                            {
                                deal(pack.pack);
                                inRange = true;
                                break;
                            }

                            else if (2 <= amount)
                            {
                                dealCard(amount, pack.pack);
                                inRange = true;
                                break;

                            }
                        }
                        else
                        {
                            Console.WriteLine("Please select a number from 1 to 52");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid Number");
                    }
                }
                return true;
            }
            // If parameter is 3 does no shuffle
            else if (typeOfShuffle == 3)
            {
                Pack pack = new Pack();
                bool inRange = false;
                while (inRange != true)
                {
                    Console.WriteLine("How many Cards do you want?");
                    string Input = Console.ReadLine();
                    bool Valid = int.TryParse(Input, out int amount);
                    if (Valid)
                    {                    
                            if (amount <= 52 && 1 <= amount) 
                            {
                                if (amount == 1)
                                {
                                    deal(pack.pack);
                                    inRange = true;
                                    break;
                                }

                                else if (2 <= amount)
                                {
                                    dealCard(amount, pack.pack);
                                    inRange = true;
                                    break;

                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select a number from 1 to 52");
                            
                            }               
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid Number");
                    }
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
                Console.WriteLine(Card.Display(card.Value, card.Suit)); // Calls Card.Display in order to format the card
            }
            Console.ReadLine();
            return deal.First(); //returns first number 
        }
        public static List<Card> dealCard(int amount, List<Card> list)
        {
            //Deals Specified AMount of Cards
            var deal = list.Take(amount);
            foreach (Card card in deal)
            {
                Console.WriteLine(Card.Display(card.Value, card.Suit));
            }
            Console.ReadLine();
            return deal.ToList(); //returns list of numbers
            

        }
    }
}

    






