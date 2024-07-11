using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TryParseFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber;
            Console.WriteLine("Enter a number: ");

            // TryParse() is used convert string to numeric types.

            if (int.TryParse(Console.ReadLine(), out myNumber))
                Console.WriteLine("Converted Successfully: " + myNumber);

            else
                Console.WriteLine("Could not convert, try again!");

            // TryParse() is used to avoid exception handling if the conversion fails. 
            Console.WriteLine("Thank you!");

        }
    }
}
