using System;

namespace module6_1
{

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
