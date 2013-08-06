using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class ConsoleWriter : IFizzBuzzWriter
    {
        public ConsoleWriter()
        {
        }

        public void AddText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
