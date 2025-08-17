using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Day4_Tutorial
{
    public class switchProgram
    {
        public void Program2()
        {
        
            Console.WriteLine("    Yesterday and Tomorrow Program");
            Console.WriteLine(".......................................");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" Notic: Months (1 3 5 7 8 10 12):  31 \n        Month 2: 28,29 \n        Months (4 6 9 11): 30");
            Console.WriteLine();
            Console.ResetColor();


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

            string [] months =
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };


            //Console.WriteLine(months [Month - 1]);
            // 1 3 5 7 8 10 12 - 31
            // 2
            // 4 6 9 11 - 30

            if ( Month >= 1 && Month <= 12 )
            {
                switch ( Month )
                {
                    case 1:
                        if ( Day == 1 )
                        {
                            Console.WriteLine($"Yesterday : 31.{months [Month + 10]}.{Year - 1}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else if ( Day == 31 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                        }

                        else if ( Day >= 2 && Day <= 30 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;

                    case 2:
                        if ( ( Year % 400 == 0 ) || ( Year % 100 != 0 && Year % 4 == 0 ) )
                        {
                            if ( Day == 1 )
                            {
                                Console.WriteLine($"Yesterday : 31. {months [Month - 2]} .{Year}");
                                Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                            }
                            else if ( Day == 29 )
                            {
                                Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                                Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                            }

                            else if ( Day >= 2 && Day <= 28 )
                            {

                                Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                                Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                            }
                        }
                        else
                        {
                            if ( Day == 1 )
                            {
                                Console.WriteLine($"Yesterday : 31.{months [Month - 2]}.{Year - 1}");
                                Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                            }
                            else if ( Day == 28 )
                            {
                                Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                                Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                            }

                            else if ( Day >= 2 && Day <= 27 )
                            {

                                Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                                Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                            }

                            else
                            {
                                Console.WriteLine("Invalid Input. Try Again!");
                            }
                        }

                        break;

                    case 3:
                        if ( Day == 1 )
                        {
                            //Console.WriteLine($"Yesterday : 28.2.{Year}");
                            //Console.WriteLine($"Tomorrow : {Day + 1}.{Month}.{Year}");

                            if ( ( ( Year - 1 ) % 400 == 0 ) || ( ( Year - 1 ) % 100 != 0 && ( Year - 1 ) % 4 == 0 ) )
                            {
                                Console.WriteLine($"Yesterday : 29.{months [Month - 2]}.{Year}");
                                Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                            }

                            else
                            {
                                Console.WriteLine($"Yesterday : 28.{months [Month - 2]}.{Year}");
                                Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                            }
                        }
                        else if ( Day == 31 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                        }

                        else if ( Day >= 2 && Day <= 30 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;

                    case 4:
                        if ( Day == 1 )
                        {
                            Console.WriteLine($"Yesterday : 31.{months [Month - 2]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else if ( Day == 30 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                        }

                        else if ( Day >= 2 && Day <= 29 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;

                    case 5:
                        if ( Day == 1 )
                        {
                            Console.WriteLine($"Yesterday : 30.{months [Month - 2]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else if ( Day == 31 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                        }

                        else if ( Day >= 2 && Day <= 30 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;

                    case 6:
                        if ( Day == 1 )
                        {
                            Console.WriteLine($"Yesterday : 31.{months [Month - 2]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else if ( Day == 30 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                        }

                        else if ( Day >= 2 && Day <= 29 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;

                    case 7:
                        if ( Day == 1 )
                        {
                            Console.WriteLine($"Yesterday : 30.{months [Month - 2]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else if ( Day == 31 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                        }

                        else if ( Day >= 2 && Day <= 30 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;

                    case 8:
                        if ( Day == 1 )
                        {
                            Console.WriteLine($"Yesterday : 30.{months [Month - 2]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else if ( Day == 31 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                        }

                        else if ( Day >= 2 && Day <= 30 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;

                    case 9:
                        if ( Day == 1 )
                        {
                            Console.WriteLine($"Yesterday : 31.{months [Month - 2]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else if ( Day == 30 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                        }

                        else if ( Day >= 2 && Day <= 29 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;

                    case 10:
                        if ( Day == 1 )
                        {
                            Console.WriteLine($"Yesterday : 30.{months [Month - 2]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else if ( Day == 31 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                        }

                        else if ( Day >= 2 && Day <= 30 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;

                    case 11:
                        if ( Day == 1 )
                        {
                            Console.WriteLine($"Yesterday : 31.{months [Month - 2]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else if ( Day == 30 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month]}.{Year}");
                        }

                        else if ( Day >= 2 && Day <= 29 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;

                    case 12:
                        if ( Day == 1 )
                        {
                            Console.WriteLine($"Yesterday : 30.{months [Month - 2]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else if ( Day == 31 )
                        {
                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : 1.{months [Month - 12]}.{Year + 1}");
                        }

                        else if ( Day >= 2 && Day <= 30 )
                        {

                            Console.WriteLine($"Yesterday : {Day - 1}.{months [Month - 1]}.{Year}");
                            Console.WriteLine($"Tomorrow : {Day + 1}.{months [Month - 1]}.{Year}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again!");
                        }
                        break;


                }
            }
            else Console.WriteLine("Invalid Month Value: Try Again!");

            Console.WriteLine();
            Console.WriteLine(".............................");
            Console.WriteLine();
            goto GG;



        }
    }
}
