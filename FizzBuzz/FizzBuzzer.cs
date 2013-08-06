using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        private int _start;
        private int _end;

        public FizzBuzzer(int start, int end)
        {
            _start = start;
            _end = end;
        }

        public void PrintToConsole()
        {
            ConsoleWriter writer = new ConsoleWriter();
            ExecuteFizzBuzz(writer);
        }

        public string GetText()
        {
            StringWriter writer = new StringWriter();
            ExecuteFizzBuzz(writer);
            return writer.GetResult();
        }

        public List<string> GetList()
        {
            ListWriter writer = new ListWriter();            
            ExecuteFizzBuzz(writer);
            return writer.GetResult();
        }

        private void ExecuteFizzBuzz(IFizzBuzzWriter writer)
        {
            Stopwatch watch = new Stopwatch();
            bool isDivisibleBy3 = default(bool);
            bool isDivisibleBy5 = default(bool);
                       
            if (_start > _end)
            {
                throw new ApplicationException("The starting number has to be less than ending number.");
            }

            watch.Start();
            for (int i = _start; i <= _end; i++)
            {
                isDivisibleBy3 = i % 3 == 0;
                isDivisibleBy5 = i % 5 == 0;

                if (isDivisibleBy3 && isDivisibleBy5)
                {
                    writer.AddText("fizzbuzz");
                }
                else if (isDivisibleBy3)
                {
                    writer.AddText("fizz");
                }
                else if (isDivisibleBy5)
                {
                    writer.AddText("buzz");
                }
                else
                {
                    writer.AddText(i.ToString());
                }
            }
            watch.Stop();
            Console.Write(string.Format("Total elapsed time: {0} seconds", watch.ElapsedMilliseconds));
        }
    }
}
