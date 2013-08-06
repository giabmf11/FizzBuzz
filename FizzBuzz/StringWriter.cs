using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class StringWriter : IFizzBuzzWriter
    {
        StringBuilder _stringBuilder = null;

        public StringWriter()
        {
            _stringBuilder = new StringBuilder();
        }

        public void AddText(string text)
        {
            _stringBuilder.AppendLine(text);
        }

        public string GetResult()
        {
            return _stringBuilder.ToString();
        }
    }
}
