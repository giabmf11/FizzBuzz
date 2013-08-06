using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class ListWriter : IFizzBuzzWriter
    {         
        List<string> _list = null;

        public ListWriter()
        {
            _list = new List<string>();
        }

        public void AddText(string text)
        {
            _list.Add(text);
        }

        public List<string> GetResult()
        {
            return _list;
        }
    }
}
