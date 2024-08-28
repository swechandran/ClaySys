using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if-else if-else
            int x = 5;
            if (x > 10)
            {
                Console.WriteLine("x is greater than 10");
            }
            else if (x == 5)
            {
                Console.WriteLine("x is equal to 5");
            }
            else
            {
                Console.WriteLine("x is less than 5");
            }
        }

        //calculating grade using switch
        class GradeCalculator
        {
            static void Main(string[] args)
            {
                Console.Write("Enter your score (0-100): ");
                int score = Convert.ToInt32(Console.ReadLine());

                string grade;
                switch (score / 10)
                {
                    case 10:
                        grade = "A";
                        break;
                    case 9:
                        grade = "B";
                        break;
                    case 8:
                        grade = "C";
                        break;
                    case 7:
                        grade = "D";
                        break;
                    default:
                        grade = "F";
                        break;
                }

                Console.WriteLine($"Your grade is {grade}");
            }
        }
        //LOOPS
        //for loop to print sum of numbers
        static void Main1(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Sum of numbers: " + sum);
        }
        // while loop to print sum of numbers
        static void Main2(string[] args)
        {
            int num = 12345;
            int sum = 0;

            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
        //do-while loop
        static void Main3(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }
             //for-each statement
            //array
            static void Main4(string[] args)
        {
            string[] colors = { "Red", "Green", "Blue", "Yellow" };

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }
        //list
        static void Main5(string[] args)
        {
            List<string> colors = new List<string> { "Red", "Green", "Blue", "Yellow" };

            foreach (string color in colors)
            {
                Console.WriteLine("Color: " + color);
            }
        }
    }
}




