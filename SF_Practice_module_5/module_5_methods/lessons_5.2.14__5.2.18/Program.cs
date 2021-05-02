using System;

namespace lessons_5._2._14__5._2._18
{
    class Program
    {

        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArray(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }

            return arr;
        }


        static void ShowArray(int[] array, bool sort = false)
        {
            var temp = array;

            if (sort)
            {
                temp = SortArray(array);
            }

            Console.WriteLine("Вывод масива:");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }

        }

        static void Main(string[] args)
        {
            var array = GetArrayFromConsole(10);
            var sortedarray = SortArray(array);
            ShowArray(array, true);
        }
    }
}
