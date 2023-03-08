using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {


        public CardValue Value { get; set; }
        public Suits Suit { get; set; }



        public Card(CardValue number, Suits suit)
        {
            Value = number;
            Suit = suit;
        }

    }


}
