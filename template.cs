using System;
namespace test1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter text: ");
            string a = Console.ReadLine();
            int b = 1;
            while (true){
                DateTime localDate = DateTime.Now;
                Console.WriteLine("[ "+b+" ] "+"[ " + localDate + " ] "+a);
                b++;
            }
        }
    }
}
