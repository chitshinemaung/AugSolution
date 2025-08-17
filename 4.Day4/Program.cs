using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Day4
{
    internal class Program
    {
        static void Main(string [] args)
        {
            #region switch
            //char ch = 'a';

            //switch(ch)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("Vowel");
            //        break;
            //    //case 'e':
            //    //    Console.WriteLine("Vowel");
            //    //    break;
            //    //case 'i':
            //    //    Console.WriteLine("Vowel");
            //    //    break;
            //    //case 'o':
            //    //    Console.WriteLine("Vowel");
            //    //    break;
            //    //case 'u':
            //    //    Console.WriteLine("Vowel");
            //    //    break;
            //    default:
            //        Console.WriteLine("Not Vowel");
            //        break;
            //}

            //object o = 1000;

            //switch ( o )
            //{
            //    case int i when i < 10000:
            //        Console.WriteLine("It's an Integer");
            //        Console.WriteLine("LT 10000");
            //        Console.WriteLine(i);
            //        break;

            //    case int j when j > 10000:
            //        Console.WriteLine("It's an Integer");
            //        Console.WriteLine("GT 10000");
            //        Console.WriteLine(j);
            //        break;

            //    case string s:
            //        Console.WriteLine("It's a string");
            //        Console.WriteLine(s);
            //        break;

            //    default:
            //        Console.WriteLine("IDK");
            //        break;



            //}
            #endregion

            int [] arr = new int [10];
            arr [0] = 1;
            arr [3] = 3;

            int start = 0;
            int end = 9;

        GG: if ( start < end )
            {
                Console.WriteLine(arr [start]);
                start++;
                goto GG;
            }

            int len = arr.Length;

            for ( int i = 0; i < len; i++ )
            {
                if ( arr [i] != 0 && arr [i] % 2 != 0 )
                {
                    Console.WriteLine($"Index {i} = {arr [i]}");
                }
            }
        }
    }
}
