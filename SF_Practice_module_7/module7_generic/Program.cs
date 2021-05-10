using System;

namespace module7_generic
{

    //Задание 7.6.2
    //Создайте класс-обобщение Car для автомобиля.Универсальным параметром будет тип двигателя
    //в автомобиле (электрический и бензиновый). Для типов двигателей также создайте
    //классы — ElectricEngine и GasEngine.
    //Задание 7.6.7
    //Добавьте к схеме классов автомобиля следующие классы частей автомобиля:
    //Battery, Differential, Wheel.Также добавьте в класс Car виртуальный обобщённый метод
    //без реализации — ChangePart, который будет принимать один параметр — newPart универсального типа.

    abstract class Engine { }

    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    abstract class CarPart { }

    class Battery : CarPart { }

    class Differential : CarPart { }

    class Wheel : CarPart { }

    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }

    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    //Задание 7.6.6
    //Реализуйте класс-обобщение Record, у которого будут два универсальных параметра:
    //один — для идентификатора записи(Id), другой — для значения записи(Value).
    //Также в классе реализуйте поле Date типа DateTime.

    class Record<T1, T2>
    {
        public T1 Id;
        public DateTime Date;
        public T2 Value;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
