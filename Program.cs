using System.ComponentModel;
using System.Diagnostics;
using System;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericCollection<string> strColl = new GenericCollection<string>();

            strColl.Add("Samuel");
            strColl.Add("Bola");
            strColl.Add("Hulabaa");
            strColl.Add("Learn");
            strColl.Add("Olowo");
            strColl.Add("Praise");
            strColl.Add("Meana");
            strColl.Add("Kive");

            var val = strColl[1];

            Console.WriteLine(val);
            Console.WriteLine(strColl.NumberOfItems);

            Console.WriteLine("--------------------------------------");
            strColl.RemoveAt(1);
            var val2 = strColl[1];

            Console.WriteLine(val2);
            Console.WriteLine(strColl.NumberOfItems);
        }
    }
}
