using System;

namespace mini_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniCalculator Calc = new MiniCalculator();

            while (true)
            {
                try
                {
                    string operation = Calc.SelectOperation();

                    switch (operation)
                    {
                        case "+":
                            {
                                try
                                {
                                    Console.WriteLine("Введите первое слагаемое: ");
                                    double a = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Введите второе слагаемое: ");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Результат:  {0} + {1} = {2}", a, b, Calc.SumTwoNumbers(a, b));
                                   
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                break;

                            }

                        case "-": Console.WriteLine("Операция пока нереализована :)  Пара пара пам! Пиу!)"); break;

                    }
                }

                catch (MyException ex) { Console.WriteLine(ex.Message); }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }

        }
    }

    public interface Sum
    {
        double SumTwoNumbers(double a, double b);
    }

    public class MiniCalculator : Sum
    {
        double number { get; set; }

        public string SelectOperation()
        {
            Console.WriteLine();
            Console.WriteLine("Необходимо ввести значение + или -");

            
            string operation = Console.ReadLine();

            if (operation != "+" && operation != "-") { throw new MyException("Введите корректное значение!"); }

            return operation;

        }


        public double SumTwoNumbers(double a, double b)
        {
            return a + b;
        }

    }


    public class MyException : Exception
    {
        public MyException(string msg) : base(msg) { }
    }

}
