using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _3.Day3
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int ans;
            int x = 10 ; int y = 5;

            ans = x + y ;
            Console.WriteLine("x + y = " + ans);

            ans = x - y ;
            Console.WriteLine("x - y = " + ans);

            ans = x * y ;
            Console.WriteLine("x * y = " + ans) ;

            ans = x / y;
            Console.WriteLine("x / y = " + ans);
            Console.WriteLine();

            bool res;

            res = x == y ;
            Console.WriteLine("x == y : " + res) ;

            res = x > y;
            Console.WriteLine("x > y : " + res);

            res = x < y;
            Console.WriteLine("x < y : " + res);

            res = x <= y;
            Console.WriteLine("x <= y : " + res);

            res = x >= y;
            Console.WriteLine("x <= y : " + res);

            res = x != y;
            Console.WriteLine("x != y : " + res);


            bool a = true, b = false, Result;

            Result = a && b;
            Console.WriteLine("a && b: " + Result);

            Result = a || b;
            Console.WriteLine("a || b: " + Result);

            Result = !b;
            Console.WriteLine("!b : " + Result);

            int age = 20; bool isCityzin = false;

            string Valid = age >= 18 ? (isCityzin == true ? "IsCitizin" : "NotCitizin") : "NotOk1";
            Console.WriteLine(Valid);

            char ch = 'k';

            if (ch == 'a' || ch == 'A')
            {
                Console.WriteLine("Vowel");
            }

            else if ( ch == 'e' || ch == 'E' )
            {
                Console.WriteLine("Vowel");
            }

            else if ( ch == 'i' || ch == 'I' )
            {
                Console.WriteLine("Vowel");
            }

            else if ( ch == 'o' || ch == 'O' )
            {
                Console.WriteLine("Vowel");
            }

            else if ( ch == 'u' || ch == 'U' )
            {
                Console.WriteLine("Vowel");
            }

            else 
            {
                Console.WriteLine(" Not Vowel");
            }


            int month = 5, year = 2024;
            // 1 3 5 7 8 10 12
            if ( month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 )
            {
                Console.WriteLine("Day31");
            }
            else if (month == 2)
            {
                if ( year % 4 == 0 )
                {
                    Console.WriteLine("Day 29");
                }
                else
                {
                    Console.WriteLine(" Day 28");
                }
            }
            else
            {
                Console.WriteLine("Day 30");
            }
        }
    }
}
