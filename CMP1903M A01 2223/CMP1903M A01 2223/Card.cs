using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CMP1903M_A01_2223
{
    public class Card
    {



        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public string Suit { get; set; }
        // val determined in the Pack class
        public Card(int val)
        {
            // Generating the corresponding cards to values and suits
            //Uses principle that each suit has 13 cards
            Value = (val % 13) + 1;
            if (val / 13 == 0)
            {
                Suit = "Diamonds";
            }
            else if (val / 13 == 1)
            {
                Suit = "Clubs";
            }
            else if (val / 13 == 2)
            {
                Suit = "Hearts";
            }
            else
            {
                Suit = "Spades";
            }
        }

            //formats the number just before output
       public static string Display(int Value, string Suit)
       {
            //Compares values and changes them if the value appears in list
            {
                if (Value == 1)
                {
                    return "Ace of " + Suit;
                }
                else if (Value == 11)
                {
                    return "Jack of " + Suit;
                }
                else if (Value == 12)
                {
                    return "Queen of " + Suit;
                }
                else if (Value == 13)
                {
                    return "King of " + Suit;
                }
                else
                { //formats the card before display
                    return Value + " of " + Suit;
                }
            }
        }
    }
}



         
       


        






    




