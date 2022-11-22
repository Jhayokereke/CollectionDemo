using System.ComponentModel;
using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            ICollection<Car> database = Database.CarTable;

            Car car1 = new Car { Id = "001" };
            Car car2 = new Car { Id = "002" };
            Car car3 = new Car { Id = "003" };

            CarRepository carRepo = new CarRepository(database);

            //adding with the use of a repository
            //with abstraction
            carRepo.Add(car1);
            Console.WriteLine($"Current number of items in the CarTable = {database.Count}");
            carRepo.Add(car2);
            Console.WriteLine($"Current number of items in the CarTable = {database.Count}");
            carRepo.Add(car3);
            Console.WriteLine($"Current number of items in the CarTable = {database.Count}");

            carRepo.Delete("002");
            Console.WriteLine($"Current number of items in the CarTable = {database.Count}");
        }
    }
}