using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutParam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mainVariable = 10;
            
            InFunction(in mainVariable);
            OutFunction(out mainVariable);
            Console.WriteLine("The values after addition of IN Main is: " +mainVariable); //10
            Console.WriteLine("The values after addition of OUT Main is: " + mainVariable); //20

        }
        static void OutFunction(out int outFunctionVariable)
        {
            outFunctionVariable = 0;
            outFunctionVariable = outFunctionVariable + 20;
            Console.WriteLine("The value after addition in Function is[out]: " +outFunctionVariable); //20
        }
        static void InFunction(in int inFunctionVariable)
        {
            //functionVariable = functionVariable + 20;
            //The above line will show compile time error as we are trying to modify it.
            Console.WriteLine("The value after adding in Function is[in]: " + inFunctionVariable); //20
        }
    }
}
