using System;

namespace SF_mod10_interface
{
    class Program
    {
        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            Logger = new Logger();

            var worker1 = new Worker1(Logger);
            var worker2 = new Worker2(Logger);
            var worker3 = new Worker3(Logger);

            worker1.Work();
            worker2.Work();
            worker3.Work();

        }
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);

    }

    public class Logger : ILogger
    {
        void ILogger.Error(string message)
        {
            Console.WriteLine(message);
        }

        void ILogger.Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }


        public interface IWorker
        {
            void Work();
        }
    }



}
