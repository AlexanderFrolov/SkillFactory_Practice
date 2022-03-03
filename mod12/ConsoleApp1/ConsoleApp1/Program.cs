using BenchmarkDotNet.Running;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<Testing>();
			Estimate(20);

			Console.ReadKey();
		}

		static void CreateMatrix(int n)
		{
			var matrix = new int[n][];

			for (int i = 0; i < n; i++)
			{
				matrix[i] = new int[n];
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					matrix[i][j] = i + j;
				}
			}
		}

		static void Estimate(int n)
		{
			for (int i = 0; i < n; i++)
			{
				CreateMatrix(10000);
			}
		}
	}
}
