using System;

namespace recursion_5._5._3__5._5._8
{
    class Program
    {
        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;

            Console.BackgroundColor = (ConsoleColor) deep;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }


        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }


        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return  N * PowerUp(N, --pow); 
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(2, 3));
            Console.WriteLine( Factorial(20));
            Console.WriteLine("Напишите что-то: ");
            string text = Console.ReadLine();
            Console.WriteLine("Укажите глубину эха: ");
            int deep = int.Parse(Console.ReadLine());
            Echo(text, deep);
        }
    }
}
