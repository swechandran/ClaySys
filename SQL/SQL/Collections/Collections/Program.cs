using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args) {
            //array
            int[] num = new int[5];
            num[0] = 1;
            num[1] = 2;
            num[2] = 3;
            num[3] = 4;
            //Console.WriteLine(num[1]);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            num[1] = 20;
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            //arraylist
           ArrayList data = new ArrayList();
            data.Add(40);
            data.Add(45);
            data.Add("swetha");
            data.Add("1.43f");
            data.Add("true");

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            data.Remove(40);
            Console.WriteLine("------afetr remove____");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            //hash table(key, value)
        Hashtable data = new Hashtable();
            data.Add(1, "swetha");
            data.Add(2, "1.4f");
            data.Add(3, null);

            Console.WriteLine(data[3]);
            foreach (DictionaryEntry item in data)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
           // dictionery(type need to mention)
        Dictionary<int, string> databook = new Dictionary<int, string>();
            databook.Add(1, "sara");
            databook.Add(2, "sri");
            databook.Add(3, "shree");
            for (int i = 0; i < databook.Count; i++)
            {
                Console.WriteLine($"{databook.Keys.ElementAt(i)}");
                Console.WriteLine($"{databook.Keys.ElementAt(i)}:{databook.Values.ElementAt(i)}");
            }
            //stack
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Count());
            Console.WriteLine(stack.Peek());
            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop());
            }




        }
    }
}
