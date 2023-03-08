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
            Console.Write("Choose a shuffle");
            Console.Write("1) Fisher Yates 2) Riffle 3) No Shuffle");
            string userInput = Console.ReadLine();

            bool isValid = int.TryParse(userInput, out int typeOfShuffle);
            if (isValid)
            {
                if (typeOfShuffle == 1)
                {
                    Pack.shuffleCardPack(1);
                }
            }
        }
    }
}