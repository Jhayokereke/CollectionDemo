using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class Generics
    {
        public void Print<T>(T val)
        {
            Console.WriteLine(val);
        }
    }
}
