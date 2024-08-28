using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
    internal class abstraction 
    {
        public abstract class Bird
        {
            // Abstract method (does not have a body)
            public abstract void MakeSound();
            // Regular method
            public void Fly()
            {
                Console.WriteLine("The bird is flying.");
            }
        }
        public class Sparrow : Bird
        {
            public override void MakeSound()
            {
                Console.WriteLine("The sparrow says: tweet tweet");
            }
        }
        public class Parrot : Bird
        {
            public override void MakeSound()
            {
                Console.WriteLine("The parrot says: squawk squawk");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Sparrow mySparrow = new Sparrow();
                mySparrow.MakeSound(); 
                mySparrow.Fly();  

                Parrot myParrot = new Parrot();
                myParrot.MakeSound(); 
                myParrot.Fly();  
            }
        }
    }
    



    }

