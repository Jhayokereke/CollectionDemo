using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class Generics
    {
        public void Print(Student student)
        {
            Console.WriteLine(student);
        }

        public void Print<T>(T val) //Print<string> //Print<int> //
        {
            Console.WriteLine(val);
        }
    }
}
