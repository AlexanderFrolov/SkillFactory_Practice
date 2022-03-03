using System;
using System.Linq;
using System.Collections.Generic;


namespace Filtering
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Андрей", "Анна", "Мария", "Сергей", "Дмитрий", "Ян" };

            var selectedPeople = from p in people
                                 where p.StartsWith("А") // фильтрация по условию
                                 orderby p // сортировка по возрастанию
                                 select p;

            foreach (string p in selectedPeople)
                Console.WriteLine(p);

            var nums = new List<int>() { 1, 2, 3, 1 };
            var orderedNums = nums.OrderBy(n => n);

            foreach (var num in orderedNums)
            {
                Console.Write(num);
            }
            Console.WriteLine();
            var whereNums = nums.Where(n => n >= 2).OrderByDescending(n => n);

            foreach (var num in whereNums)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine();

            var objects = new List<object>()
            {
               1,
               "Сергей ",
               "Андрей ",
               300,
            };

            foreach( var stringObject in objects.Where(a => a is string).OrderBy(a => a) )
                Console.WriteLine(stringObject);
            

        }
    }
}
