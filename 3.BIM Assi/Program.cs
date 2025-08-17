using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.BIM_Assi
{
    internal class Program
    {
        static void Main(string [] args)
        {
        GG:
            Console.WriteLine("This is BMI Calculator");
            Console.WriteLine("................................");
            Console.WriteLine("\n");

            double bmiResult;
        
            Console.Write("Enter you Weight (LB)    : ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter your Height (Feed and Inches eg. 5.6) : ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine();

            bmiResult = weight / height;
        
            if ( bmiResult < 18.5 )
            {
                Console.WriteLine("Your Underweight");
                Console.WriteLine();
            }
            else if ( bmiResult >= 18.5 && bmiResult < 25 )
            {
                Console.WriteLine("Your Normalweight");
                Console.WriteLine();
            }
            else if ( bmiResult >= 25 && bmiResult < 30 )
            {
                Console.WriteLine("Your Overweight");
                Console.WriteLine();
            }
            else if ( bmiResult >= 30 )
            {
                Console.WriteLine("Your Obese");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error! Try Again");
                Console.WriteLine();
            }
            goto GG;
            


        }
    }
}
