using System;

namespace module4_Basic_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Цикл for");
            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("Iteration {0}", i);
            //    switch (Console.ReadLine())
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            Console.WriteLine("Your color is red!");
            //            break;
            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            Console.WriteLine("Your color is green!");
            //            break;
            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            Console.WriteLine("Your color is cyan!");
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }
            //}

            Console.WriteLine("Цикл while");
            int k = 0;
            while (k < 2)
            {
                Console.WriteLine(k);
                Console.WriteLine("Напишите свой любимый цвет с маленькой буквы на английском языке");
                var text = Console.ReadLine();

                if (text == "stop")
                {
                    Console.WriteLine("цикл остановлен");
                    break;
                }

                switch (text)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is cyan!");
                        break;
                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your color is yellow!");
                        break;
                    default:
                        continue;

                }
                k++;
            }

            //Console.WriteLine("Цикл do while");
            //int t = 1;
            //do
            //{
            //    Console.WriteLine(t);
            //    // тут switch код
            //    t++;
            //} while (t < 0);

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Имя по буквам:");
            foreach (var item in name)
            {
                Console.Write(" " + item);
            }
            Console.Write(" Последняя буква вашего имени: {0}", name[name.Length - 1]);



        }
    }
}
