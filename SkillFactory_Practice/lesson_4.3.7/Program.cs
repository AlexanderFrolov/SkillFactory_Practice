using System;

namespace lesson_4._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();

            foreach (var ch in name)
            {
                Console.Write(" " + ch);
            }

            Console.WriteLine();
            Console.WriteLine("А теперь реверс:");

            for(int i = name.Length - 1; i > -1; i--)
            {
                Console.Write(name[i] + " ");
            }


        }
    }
}
