using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace telegram_bot
{
    class Program
    {
    
        static void Main(string[] args)
        {
            var bot = new BotWorker();
            bot.Initialize();
            bot.Start();

            Console.WriteLine("Напишите stop для прекращения работы");

            string command;
            do
            {
                command = Console.ReadLine();

            } while (command != "stop");

            bot.Stop();

            //var me = botClient.GetMeAsync().Result;
            //Console.WriteLine(
            //  $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
            //);

        }
    }
}
