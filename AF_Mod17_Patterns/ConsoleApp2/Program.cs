using System;
using ConsoleApp1;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A a = new A();
            B b = new B();
            C c = new C();

            a.Display();    // метод класса A
            b.Display();    // метод класса B
            ((A)b).Display();   // метод класса B

            c.Display();    // метод класса C
            ((A)c).Display();   // метод класса B
            ((B)c).Display();   // метод класса B
            D pica = new D();

        }

        class A
        {
            public virtual void Display()
            {
                Console.WriteLine("Вызван метод класса A");
            }
        }
        class B : A
        {
            public override void Display()
            {
                Console.WriteLine("Вызван метод класса B");
            }
        }
        class C : B
        {
            public new void Display()
            {
                Console.WriteLine("Вызван метод класса C");
            }
        }

        public class D
        {
            public readonly int Count = 5;
            public const double Pi = 3.141592; // неявно считается статическим
            public D()
            {
                Count = 1;
            }
        }

    }
}
