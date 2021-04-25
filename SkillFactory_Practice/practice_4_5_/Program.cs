using System;

namespace practice_4_5_
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Заполните пожалуйста анкету #{0}!", j+1);

                (string Name, string LastName, string Login, int LoginLength, bool HasPet, byte Age, string[] favcolors) User;

                Console.WriteLine("Введите имя:");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию:");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин:");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("У вас есть домашние животные?");
                User.HasPet = Console.ReadLine() == "да" ? true : false;

                Console.WriteLine("Введите ваш возраст");
                User.Age = (byte)int.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите ваши 3 любимых цвета:");

                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    Console.WriteLine("Цвет №" + (i + 1));
                    User.favcolors[i] = Console.ReadLine();
                }
            }


        }
    }
}
