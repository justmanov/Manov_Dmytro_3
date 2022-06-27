using System;
using System.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        private static void Main()
        {
            int D = 9;
            int[] A = { 0, 63, 129, -6, 25, 999, -43, 50 };

            var result = A.FirstOrDefault(e => (e > 0) && (e % 10 == D));
            for(int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();

            Console.WriteLine($" Результат {result}");

            Console.ReadLine();
        }
    }
}
