using System;
using System.Collections.Generic;

namespace delegate_events
{
    class MyException : FormatException
    {
        public MyException(string msg) : base(msg) { }
        
    }

    class Program
    {
        static List<string> surnames = new List<string> { "Иванов", "Фролов", "Соколов", "Смирнов", "Петров" };

        static void Main(string[] args)
        {

            SortingLastNames sortLastNames = new SortingLastNames();
            sortLastNames.SortSurnamesEvent += SelectSortingMethod;

            while (true)
            {
                try
                {
                    sortLastNames.ReadNumber();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }

        static void SelectSortingMethod(int number)
        {   
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Сортируем фамилии по возрастанию");
                        surnames.Sort();                  
                        foreach (var surname in surnames)
                        {
                            Console.WriteLine(surname);
                        }       
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Сортируем фамилии по убыванию");
                        surnames.Sort();
                        surnames.Reverse();
                        foreach (var surname in surnames)
                        {
                            Console.WriteLine(surname);
                        }
                        break;
                    }
            }
        }

    }

    class SortingLastNames
    {
        public delegate void SortSurnamesDelegate(int number);
        public event SortSurnamesDelegate SortSurnamesEvent;
        public void ReadNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Введите значение 1 если сортировка по возрастанию (А-Я) или 2 если по убыванию (Я-А):");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) { throw new MyException("Ошибка! Необходимо ввести значение 1 если сортировка по возрастанию или 2 если по убыванию"); }

            Sort(number);

        }

        protected virtual void Sort(int number)
        {
            SortSurnamesEvent?.Invoke(number);
        }

    }

}
