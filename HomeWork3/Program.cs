using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число длинны массива\t");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Введите числа в массив\n");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число массива {arr[i]} присвоено [{i}]");
            }
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < n; i++)
            {
                if (max < arr[i]) { max = arr[i]; }
                if (min > arr[i]) { min = arr[i]; }

            }
            Console.WriteLine($"Минимальное число {min}");
            Console.WriteLine($"Максимальное число {max}");
            int maximum = 0;
            int minimum = 0;
            int b;
            for (int i = 0; i < n; i++)
            {
                if (arr[maximum] < arr[i]) { maximum = i; }
                if (arr[minimum] > arr[i]) { minimum = i; }
            }
            b = arr[minimum];
            arr[minimum] = arr[maximum];
            arr[maximum] = b;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }



            Console.ReadKey();
        }
    }
}
