using System;

namespace module7_2
{
    // 7.2.3
    class BaseClass
    {
        public  virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public override sealed void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DeriedClass");
        }
    }

    // 7.2.3
    class Citizen
    {
        public virtual double Age
        {
            get;
            set;
        }

        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }

    class CivilServant : Citizen
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class President : CivilServant
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 35)
                {
                    Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    // 7.2.4
    class BaseClass2
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass2 : BaseClass2
    {
        private int counter;
        public override int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value >= 0)
                {
                    Console.WriteLine("Число должно быть больше 0");
                }        
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DerivedClass der = new DerivedClass();
            der.Display();
            DerivedClass2 der2 = new DerivedClass2();
            der2.Counter = -1;
            Console.WriteLine(der2.Counter);
            DerivedClass obj = new DerivedClass();
            obj.Display();
        }
    }
}
