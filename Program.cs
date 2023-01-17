using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_4300_First_Deliverable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Solution (1): Hello, World!");
            Console.WriteLine(" ");

            string stg = "Hello, World!";
            Console.WriteLine("Solution (2): " + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a user's name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The user's name is: " + userName);
            Console.WriteLine(" ");

            Console.WriteLine("Enter the user's age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The user's age is: " + age);


        }
    }
}

