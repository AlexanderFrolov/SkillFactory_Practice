using System;

namespace module7_7._2._7
{
    class Program
    {   
        class A
        {
            public virtual void Display() { Console.WriteLine("A"); }
        }
        class B : A
        {
            public new void Display() { Console.WriteLine("B");}
        }
        class C : A
        {
            public override void Display() { Console.WriteLine("C"); }
        }
        class D : B
        {
            public new void Display() { Console.WriteLine("D"); }
        }
        class E : C
        {
            public new void Display() { Console.WriteLine("E"); }
        }


        // 7.2.12
        //Для класса Obj перегрузите операторы + и -, чтобы результатом работы оператора был новый экземпляр
        //класса Obj, а операции производились над полем Value.

        class Obj
        {
            public int Value;

            public static Obj operator + (Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value + b.Value
                };
            }
            public static Obj operator - (Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value - b.Value
                };
            }
        }


            static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            D d = new D();
            E e = new E();
            // D C B A
            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
        }
    }
}
