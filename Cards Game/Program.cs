using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("   Standard Deck of Cards");
            Console.WriteLine("..............................");
            Console.WriteLine();

            //short Diamonds = 1;
            //short Clubs = 2;
            //short Hearts = 3;
            //short Spades = 4;
            //short FaceCardsTotal = 5;
            //short TotalAllCards = 6;

            Console.WriteLine("You Can Choose a Number 1 to 6 . \n Diamond : 1 \n Clubs   : 2 \n Hearts  : 3 \n Spades  : 4 \n" +
                                " FaceCardsTotal : 5 \n TotalAllCards  : 6 \n");
        GG:
            Console.Write("Your Number is: ");
            short choose = short.Parse(Console.ReadLine());

            if ( choose == 1 )
            {
                Console.WriteLine("Total Diamond Card: 13 Cards \n");
            }
            else if ( choose == 2 )
            {
                Console.WriteLine("Total Clubs Card: 13 Cards \n");
            }
            else if ( choose == 3 )
            {
                Console.WriteLine("Total Hearts Card: 13 Cards \n");
            }
            else if ( choose == 4 )
            {
                Console.WriteLine("Total Spades Card: 13 Cards \n");
            }
            else if ( choose == 5 )
            {
                Console.WriteLine("FaceCardsTotal: 12 Cards \n");
            }
            else if ( choose == 6 )
            {
                Console.WriteLine("TotalAllCards: 52 Cards \n");
            }

            else
            {
                Console.WriteLine(" Invalid Number. Try Again! \n");
            }

            goto GG;
        }
    }
}
