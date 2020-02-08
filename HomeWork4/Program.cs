using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ячеек строк массива ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число ячеек столбцов массива");

            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] arr = new int[n, m];

            int b = 0;
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{c}\t");

                for (int j = 0; j < m - 1; j++)
                {
                    b++;
                    Console.Write($"{b}\t");
                }
                b++;
                c = c + m;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
