using System;
using System.Collections.Generic;
using System.Linq;

namespace AF_Mod15_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Список моделей
            var cars = new List<Car>()
            {
                new Car() { Model  = "SX4", Manufacturer = "Suzuki"},
                new Car() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
                new Car() { Model  = "Jimny", Manufacturer = "Suzuki"},
                new Car() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
                new Car() { Model  = "Camry", Manufacturer = "Toyota"},
                new Car() { Model  = "Polo", Manufacturer = "Volkswagen"},
                new Car() { Model  = "Passat", Manufacturer = "Volkswagen"},
            };

            // Список автопроизводителей
            var manufacturers = new List<Manufacturer>()
            {
                new Manufacturer() { Country = "Japan", Name = "Suzuki" },
                new Manufacturer() { Country = "Japan", Name = "Toyota" },
                new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
            };

            var result = from car in cars
                         join m in manufacturers on car.Manufacturer equals m.Name
                         select new
                         {
                             Name = car.Model,
                             Manufacturer = m.Name,
                             Country = m.Country
                         };

            // выведем результаты
            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Manufacturer} ({item.Country})");

            // альтернатива через методы расширения
            var result2 = cars.Join(manufacturers,
                car => car.Manufacturer,
                m => m.Name,
                (car, m) =>
                new
                {
                    Name = car.Model,
                    Manufacturer = m.Name,
                    Country = m.Country
                });
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
    }

    // Завод - изготовитель
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
