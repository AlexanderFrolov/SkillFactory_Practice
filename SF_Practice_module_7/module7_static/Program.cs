using System;

namespace module7_static
{

    class Obj
    {
        public string Name;
        public string Description;
        public static int MaxValue;
    }

    //Аналогично полям создаются статические свойства:
    class Counter
    {
        private static int increasingCounter;
        public static int IncreasingCounter
        {
            get
            {
                return increasingCounter;
            }
            set
            {
                if (value > increasingCounter)
                {
                    increasingCounter = value;
                }
            }
        }
    }


    // 7.5.3 
    // Создайте класс Helper и определите в нем статический метод Swap типа void, который принимает
    // 2 переменные типа int и меняет их значения местами.
    class Helper
    {
        public static void Swap(ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }


    // поведение статического конструктора
    class Car
    {
        public static int MinPrice = 100_000;
        public static int MaxPrice;

        static Car()
        {
            Console.WriteLine("Вызван статический конструктор класса Car");
            MaxPrice = 1_000_000;
        }

        public int Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine(Car.MinPrice);

            Console.WriteLine(Car.MaxPrice);

            Console.ReadKey();
        }
    }



}
