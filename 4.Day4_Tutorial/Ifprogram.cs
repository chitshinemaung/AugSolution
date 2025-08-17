using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4.Day4_Tutorial
{
    public class Ifprogram
    {
        public void Program1()
        {
            Console.WriteLine("    Yesterday and Tomorrow Program");
            Console.WriteLine(".......................................");
            Console.WriteLine();
        //userinput = day, month, year;
        //Output Answer = yesterday and tomorrow
        GG:
            Console.Write("Enter Day: ");
            string day = Console.ReadLine();
            bool IsDay = int.TryParse(day, out int Day);
            if ( !IsDay ) return;
            Console.WriteLine();

            Console.Write("Enter Month: ");
            string month = Console.ReadLine();
            bool IsMonth = int.TryParse(month, out int Month);
            if ( !IsMonth ) return;
            Console.WriteLine();

            Console.Write("Enter Year: ");
            string year = Console.ReadLine();
            bool IsYear = int.TryParse(year, out int Year);
            if ( !IsYear ) return;
            Console.WriteLine();

            // 1 3 5 7 8 10 12 - 31
            // 2
            // 4 6 9 11 - 30

            
            


            if ( Month == 1 )
            {
                if ( Day == 1 )
                {
                    Console.WriteLine($"Yesterday : 31.12.{Year-1}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else if ( Day == 31 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                }

                else if ( Day >= 2 && Day <= 30 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }

            else if ( Month == 2 )
            {
                if ( ( Year % 400 == 0 ) || ( Year % 100 != 0 && Year % 4 == 0 ) )
                {
                    if ( Day == 1 )
                    {
                        Console.WriteLine($"Yesterday : 31.1.{Year - 1}");
                        Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                    }
                    else if ( Day == 29 )
                    {
                        Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                        Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                    }

                    else if ( Day >= 2 && Day <= 28 )
                    {

                        Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                        Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                    }
                }
                else
                {
                    if ( Day == 1 )
                    {
                        Console.WriteLine($"Yesterday : 31.1.{Year - 1}");
                        Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                    }
                    else if ( Day == 28 )
                    {
                        Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                        Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                    }

                    else if ( Day >= 2 && Day <= 27 )
                    {

                        Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                        Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                    }

                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again!");
                    }
                }
            }

            else if ( Month == 3 )
            {
                if ( Day == 1 )
                {
                    //Console.WriteLine($"Yesterday : 28.2.{Year}");
                    //Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");

                    if ( ( ( Year - 1 ) % 400 == 0 ) || ( ( Year - 1 ) % 100 != 0 && ( Year - 1 ) % 4 == 0 ) )
                    {
                        Console.WriteLine($"Yesterday : 29.2.{Year}");
                        Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                    }

                    else
                    {
                        Console.WriteLine($"Yesterday : 28.2.{Year}");
                        Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                    }
                }
                else if ( Day == 31 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                }

                else if ( Day >= 2 && Day <= 30 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }

            else if ( Month == 4 )
            {
                if ( Day == 1 )
                {
                    Console.WriteLine($"Yesterday : 31.3.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else if ( Day == 30 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                }

                else if ( Day >= 2 && Day <= 29 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }

            else if ( Month == 5 )
            {
                if ( Day == 1 )
                {
                    Console.WriteLine($"Yesterday : 30.4.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else if ( Day == 31 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                }

                else if ( Day >= 2 && Day <= 30 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }

            else if ( Month == 6 )
            {
                if ( Day == 1 )
                {
                    Console.WriteLine($"Yesterday : 31.5.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else if ( Day == 30 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                }

                else if ( Day >= 2 && Day <= 29 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }

            else if ( Month == 7 )
            {
                if ( Day == 1 )
                {
                    Console.WriteLine($"Yesterday : 30.6.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else if ( Day == 31 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                }

                else if ( Day >= 2 && Day <= 30 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }

            else if ( Month == 8 )
            {
                if ( Day == 1 )
                {
                    Console.WriteLine($"Yesterday : 31.7.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else if ( Day == 31 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                }

                else if ( Day >= 2 && Day <= 30 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }

            else if ( Month == 9 )
            {
                if ( Day == 1 )
                {
                    Console.WriteLine($"Yesterday : 31.8.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else if ( Day == 30 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                }

                else if ( Day >= 2 && Day <= 29 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }

            else if ( Month == 10 )
            {
                if ( Day == 1 )
                {
                    Console.WriteLine($"Yesterday : 30.9.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else if ( Day == 31 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                }

                else if ( Day >= 2 && Day <= 30 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }

            else if ( Month == 11 )
            {
                if ( Day == 1 )
                {
                    Console.WriteLine($"Yesterday : 31.10.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else if ( Day == 30 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.{Month + 1}.{Year}");
                }

                else if ( Day >= 2 && Day <= 29 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }

            else if ( Month == 12 )
            {
                if ( Day == 1 )
                {
                    Console.WriteLine($"Yesterday : 30.{Month - 1}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else if ( Day == 31 )
                {
                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : 1.1.{Year + 1}");
                }

                else if ( Day >= 2 && Day <= 30 )
                {

                    Console.WriteLine($"Yesterday : {Day - 1}.{Month}.{Year}");
                    Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!");
                }
            }
                     
            else
            {
                Console.WriteLine("Error. Try Again!");
            }

            Console.WriteLine();
            Console.WriteLine("...........................");
            Console.WriteLine();
            goto GG;
        }
    }
}
