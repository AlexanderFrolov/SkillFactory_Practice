using System;

namespace module7_1
{
	class Car
	{
		public double Fuel;

		public int Mileage;

		public Car()
		{
			Fuel = 50;
			Mileage = 0;
		}

		public void Move()
		{
			// Move a kilometer
			Mileage++;
			Fuel -= 0.5;
		}

		public void FillTheCar()
		{
			Fuel = 50;
		}
	}

	enum FuelType
	{
		Gas = 0,
		Electricity
	}

	class HybridCar : Car
	{
		public FuelType FuelType;

		public void ChangeFuelType(FuelType type)
		{
			FuelType = type;
		}
	}


	class Employee
	{
		public string Name;
		public int Age;
		public int Salary;
	}

	class ProjectManager : Employee
    {
		public string ProjectName;
    }

	class Devrloper : Employee
    {
		public string ProgrammingLanguage;
    }


	class Food { }

	class Fruit : Food { }

	class Vegetable : Food { }

	class Apple : Fruit { }

	class Banana : Fruit { }

	class Pear : Fruit { }

	class Potato : Vegetable { }

	class Carrot : Vegetable { }

	class Obj
	{
		private string name;
		private string owner;
		private int length;
		private int count;

		public Obj(string name, string ownerName, int objLength, int count)
		{
			this.name = name;
			owner = ownerName;
			length = objLength;
			this.count = count;
		}
	}

	// Задание 7.1.10 
	class BaseClass
	{
		protected string Name;

		public BaseClass(string name)
		{
			Name = name;
		}
	}

	class DerivedClass : BaseClass
	{
		public string Description;
		public int Counter;

		public DerivedClass(string description, string name) : base(name)
        {
			this.Description = description;
        }

	
		public DerivedClass(string name, string description, int counter) : this(name, description)
		{
			Counter = counter;
		}

	}

	class Program
    {
        static void Main(string[] args)
        {
			HybridCar Car = new HybridCar();
			Console.WriteLine(Car.Mileage);

        }
    }
}
