using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Choose a shuffle");
            Console.WriteLine("1) Fisher Yates 2) Riffle 3) No Shuffle");
            string userInput = Console.ReadLine(); //Allows user to choose a shuffle

            bool isValid = int.TryParse(userInput, out int typeOfShuffle); //ensures input is a number
            if (isValid)
            {
                Pack.shuffleCardPack(typeOfShuffle); //sends choice to shuffleCardPack

            }
            else
            {
                Console.WriteLine("Invalid Input"); //error message for invalid input
            }
            
            
            
            
            
        }
    }
}