using System;

namespace HomeProject
{
    class Program
    {   

        static string[] CreateArrayPets(int numPets)
        {
            string[] array = new string[numPets];
            Console.WriteLine("У вас есть питомцы. Запишем клички");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите кличку вашего {0}-го питомца: ", i + 1);
                array[i] = Console.ReadLine(); 
            }
            return array;
        }

        static string[] CreateArrayFavColors(int numColors)
        {
            var array = new string[numColors];
            Console.WriteLine("У вас есть любимые цвета. Запишем их названия");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите название {0}-го цвета: ", i + 1);
                array[i] = Console.ReadLine();
            }
            return array;
        }


        static bool CheckNumber(string msg, out int number)
        {
            bool isCorrect = int.TryParse(msg, out number);
            return number != 0 && isCorrect ? false : true;
        }

        static void ShowUserData((string Name, string Surname, int Age, int NumColors, string[] FavColors, bool IsPets, int NumPets, string[] PetsName) User)
        {   
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Данные :");
            Console.WriteLine("==============");
            Console.Write(" Имя: {0}\n " +
                          "Фамилия: {1}\n " +
                          "Возраст: {2}\n ",
                          User.Name, User.Surname, User.Age);
            Console.WriteLine("Количество животных : {0}", User.NumPets);
            if (User.IsPets)
            {
                Console.WriteLine(" Клички животных: ");
                foreach (var name in User.PetsName)
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine(" Количество любимых цветов: {0}", User.NumColors);
            Console.WriteLine(" Список любимых цветов: ");
            foreach (var color in User.FavColors)
            {
                Console.WriteLine(" {0}", color);
            }
            Console.WriteLine("==============");
            Console.WriteLine("Cпасибо за предоставленные данные! ");
        }

        static (string Name, string Surname, int Age, int NumColors, string[] FavColors, bool IsPets, int NumPets, string[] PetsName) CreateQuestionnaire()
        {
            (string Name, string Surname, int Age, int NumColors, string[] FavColors, bool IsPets, int NumPets, string[] PetsName) User;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Здравствуйте! Заполните пожалуйста анкету");

            Console.Write("Введите свое имя: ");
            User.Name = Console.ReadLine();

            Console.Write("Введите свою фамилию: ");
            User.Surname = Console.ReadLine();

            int correctNumber;
            do
            {
                Console.Write("Введите свой возраст: ");
            } while (CheckNumber(Console.ReadLine(), out correctNumber));
            User.Age = correctNumber;

            Console.Write("У Вас есть питомцы? введите 'да' если есть: ");
            string answer = Console.ReadLine();

            if (answer == "да")
            {
                User.IsPets = true;
                do
                {
                    Console.Write("Введите количество питомцев: ");
                } while (CheckNumber(Console.ReadLine(), out correctNumber));
                User.NumPets = correctNumber;
                User.PetsName = CreateArrayPets(User.NumPets);
            }
            User.IsPets = false;
            User.NumPets = 0;
            User.PetsName = new string[0];

            do
            {
                Console.Write("Введите количество любимых цветов: ");
            } while (CheckNumber(Console.ReadLine(), out correctNumber));

            User.NumColors = correctNumber;
            User.FavColors = CreateArrayFavColors(User.NumColors);

            return User;

        }

        static void Main(string[] args)
        {
            ShowUserData( CreateQuestionnaire() );
        }
    }
}
