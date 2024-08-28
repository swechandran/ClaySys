using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
    internal class delegates
    {
   
           // Declare a delegate type
        delegate int MathOperation(int x, int y);
        static void Main(string[] args)
        {
            // Create instances of the delegate
            MathOperation add = Add;
            MathOperation subtract = Subtract;
            MathOperation multiply = Multiply;

            // Invoke the delegates
            Console.WriteLine("Add: " + add(5, 3));
            Console.WriteLine("Subtract: " + subtract(5, 3));
            Console.WriteLine("Multiply: " + multiply(5, 3));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}

