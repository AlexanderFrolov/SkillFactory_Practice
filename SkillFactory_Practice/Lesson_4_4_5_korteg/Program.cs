using System;

namespace Lesson_4_4_5_korteg
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine("Введите вид питомца");
            Pet.Type = Console.ReadLine();

            Console.WriteLine("Введите возрас питомца");
            Pet.Age = double.Parse(Console.ReadLine());
        }
    }
}
