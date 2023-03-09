using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public void TestShuffleAndDeal()
        {
            // Create a new Pack object
            Pack pack = new Pack();

            //checks each type of shuffle
            bool shuffle1 = Pack.shuffleCardPack(1);
            bool shuffle2 = Pack.shuffleCardPack(2);
            bool shuffle3 = Pack.shuffleCardPack(3);
            if (shuffle1 == true)
            {
                Console.WriteLine("Shuffle Successful");
            }
            else if (shuffle2 == true)
            {
                Console.WriteLine("Shuffle Successful");

            }
            else if (shuffle3 == true)
            {
                Console.WriteLine("Shuffle Successful");
            }
            else
            {
                Console.WriteLine("Shuffle unsuccsessful");
            }


            // Deal one card from the pack
            Card dealtCard = Pack.deal(pack.pack);
            Console.WriteLine("Dealt card: " + Card.Display(dealtCard.Value, dealtCard.Suit));

            // Deal two cards from the pack
            List<Card> dealtCards = Pack.dealCard(2, pack.pack);
            Console.WriteLine("Dealt cards: ");
            foreach (Card card in dealtCards)
            {
                Console.WriteLine(Card.Display(card.Value, card.Suit));
            }
           
            }
    }
   






}
