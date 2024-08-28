namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printer();
            Console.WriteLine(calc());
        }
        //non return type
        public static void Printer()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("This is function");
            Console.WriteLine(c);
            Console.ReadKey();

        }
         //return type
        public static int calc() 
        {
                int a = 10;
                int b = 20;
                int c = a + b;
            return c;

         }
    }
}