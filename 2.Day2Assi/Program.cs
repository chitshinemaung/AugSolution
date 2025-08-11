using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Day2Assi
{
    internal class Program
    {
        static void Main(string [] args)
        {
            

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Enter NRC: ");
            string nrc = Console.ReadLine();

            Console.Write("Enter Gender: ");
            string Gender = Console.ReadLine();

            Console.Write("Enter Nationlity: ");
            string nationlity = Console.ReadLine();

            Console.Write("Enter Religion: ");
            string religion = Console.ReadLine();

            Console.Write("Enter Education: ");
            string education = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter PhoneNumber: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("\n \n");

            Console.WriteLine("\t   CURRICULUM VITAE");
            Console.WriteLine("\t -----------------------");
            Console.WriteLine();

            Console.WriteLine($"Name               : {name} \n");
            Console.WriteLine($"Age                : {Age} \n");
            Console.WriteLine($"NRC                : {nrc}  \n");
            Console.WriteLine($"Gender             : {Gender}  \n");
            Console.WriteLine($"Nationlity         : {nationlity}  \n");
            Console.WriteLine($"Religion           : {religion}   \n");
            Console.WriteLine($"Education          : {education}   \n");
            Console.WriteLine($"Email              : {email}   \n");
            Console.WriteLine($"PhoneNumber        : {phone}   \n");
            Console.WriteLine($"Address            : {address}");



        }
    }
}
