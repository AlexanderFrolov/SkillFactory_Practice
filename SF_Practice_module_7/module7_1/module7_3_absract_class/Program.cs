using System;

namespace module7_3_absract_class
{
    abstract class AbstractClass
    {
        public string Name;
    }


    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work() { }
    }
    class MotherBoard : ComputerPart
    {
        public override void Work() { }
    }
    class GraphicCard : ComputerPart
    {
        public override void Work() { }
    }

    abstract class FourLeggedAnimal
    {
        public abstract string Name
        {
            get;
            set;
        }
    }

    class Dog : FourLeggedAnimal
    {
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    class Cat : FourLeggedAnimal
    {
        public override string Name
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
