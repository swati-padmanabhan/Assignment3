using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArrayAssgn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition(2, 6, 4); // output will be 12
            Addition(10, 20, 30); // output will be 60
        }

        // param helps us to define a method paramater that can accept variable number of arguments of the same type without using array.
        static void Addition(params int[] myNumbers)
        {
            int sum = 0;
            foreach (int number in myNumbers) 
            {
                sum = sum + number;
            }
            Console.WriteLine(sum);
        }
    }
}
