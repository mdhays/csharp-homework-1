using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    class Program
    {

        static void Main(string[] args)
        {

            string checkInputVal = "1121995";

            Console.WriteLine("The numbers Mason, what do they mean?");

            string userInput = Console.ReadLine();

            if (userInput == checkInputVal)
            {

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("You stopped WWIII!");

                Console.ReadLine();
            }

            else
            {

                Console.Beep();

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("R.I.P");

                Console.ReadLine();

            }
        }
    }
}