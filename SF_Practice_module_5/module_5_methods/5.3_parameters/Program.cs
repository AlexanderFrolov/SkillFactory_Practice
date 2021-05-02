using System;

namespace _5._3_parameters
{
    class Program
    {
        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }

        static int[] GetArrayFromConsole(ref int num)
        {
            num = 6;
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }
        static void Main(string[] args)
        {
            var someName = "Евгения";
            GetName(ref someName);
            Console.WriteLine(someName);

            var arr = new int[] { 1, 2, 3 };    
            BigDataOperation(arr);

            Console.WriteLine(arr[0]);
        }
    }
}
