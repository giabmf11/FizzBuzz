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
            try
            {
                FizzBuzz.FizzBuzzer fizzBuzz = new FizzBuzz.FizzBuzzer(1, 10000000);
                Console.WriteLine("Hit any key to start test...");
                Console.ReadLine();
                Console.WriteLine("Starting String....");
                fizzBuzz.GetText();
                Console.WriteLine("Hit any key to continue...");
                Console.ReadLine();
                Console.WriteLine("Starting List....");
                fizzBuzz.GetList();
                Console.WriteLine("Hit any key to end...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
