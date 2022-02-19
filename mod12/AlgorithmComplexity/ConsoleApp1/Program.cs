using System;
using System.Collections.Generic;
using System.Threading;

namespace practice_12_1_5
{


    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }


    class Program
    {
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("practice_12_1_5");
            //добавим несколько пользователей 
            List<User> users = new List<User>(){ new User { Name = "Alex", Login = "AlexLogin", IsPremium = true  },
                                                 new User { Name = "John", Login = "JohnLogin", IsPremium = false  },
                                                 new User { Name = "Olivia", Login = "OliviaLogin", IsPremium = false  }};
            
            foreach (var user in users)
            {
                // имитация входа пользователей
                Console.WriteLine("Вход...");
                Console.WriteLine("Добро пожаловать, " + user.Name + "!");

                // проверка наличия премиум подписки
                if (!user.IsPremium)
                    // показ рекламы если нет премиума
                    ShowAds();
                Thread.Sleep(200);
            }
        }
    }
}
