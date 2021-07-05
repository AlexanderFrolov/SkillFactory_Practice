using System;

namespace module9
{

    class MyException : Exception
    {
        public MyException(string msg) : base(msg) { }
    }

    class Program
    {   
        static void Main(string[] args)
        {

            Exception[] exceptions = { new MyException("мое исключение"),
                                       new IndexOutOfRangeException(),
                                       new DivideByZeroException(),
                                       new ArgumentException(),
                                       new NotSupportedException(),
                                       new TimeoutException()
            };

            foreach (var exception in exceptions)
            {
                
                try
                {
                    throw exception;
                }

                catch (System.DivideByZeroException ex) { Console.WriteLine(ex.Message); }
                catch (System.ArgumentException ex) { Console.WriteLine(ex.Message); }
                catch (System.NotSupportedException ex) { Console.WriteLine(ex.Message); }
                catch (System.IndexOutOfRangeException ex) { Console.WriteLine(ex.Message); }
                catch (System.TimeoutException ex) { Console.WriteLine(ex.Message); }
                catch (MyException ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}
