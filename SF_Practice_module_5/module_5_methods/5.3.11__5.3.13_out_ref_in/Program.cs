using System;

namespace _5._3._11__5._3._13_out_ref_in
{
    class Program
    {   
        static int SumNumbers(ref int num1, in int num2, out int num3, int num4)
        {
            num1 = 5;
            num3 = num1 + num2;
            return num3;
        }

        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 2;
            int num4 = 2;
            int num3 = SumNumbers(ref num1, num2, out num3, num4);
            
         
            Console.WriteLine("Результат: {0}", num4 * num3);
        }
    }
}
