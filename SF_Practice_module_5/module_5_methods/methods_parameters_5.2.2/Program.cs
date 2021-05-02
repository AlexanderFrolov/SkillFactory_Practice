using System;

namespace methods_parameters_5._2._2
{
    class Program
    {

        static string ShowColor(string username, int age)
        {
            Console.WriteLine("{0}, {1} лет \n Напишите свой любимый цвет на английском с маленькой буквы", username, age);
            var color = Console.ReadLine();

            switch (color)
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
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }


        static void ShowColors(string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        //static void ShowColors(string username = "Jane", params string[] favcolors)
        static void ShowColors_2(string username, params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);

            } 
        }


        static void Main(string[] args)
        {
           var (name, age) = ("Евгения", 27);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);


            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }

            ShowColors_2(name, favcolors);
            //Console.WriteLine("Ваши любимые цвета: ");
            //foreach (var color in favcolors)
            //{
            //    Console.WriteLine(color);
            //}

            Console.ReadKey();
        }
    }
}
