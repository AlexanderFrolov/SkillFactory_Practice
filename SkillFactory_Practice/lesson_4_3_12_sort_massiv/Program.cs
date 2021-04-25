using System;

namespace lesson_4_3_12_sort_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            // необходимо отсортировать его в порядке возрастания цифр и вывести на экран.
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
         
            int temp;

            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item);
            }

            // Необходимо найти сумму всех его элементов.

            int summ = 0;
            foreach (var item in arr)
            {
                summ += item;
            }

            Console.WriteLine("сумма равна: {0}", summ);


            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var stroke in array)
            {
                foreach (var item in stroke)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
