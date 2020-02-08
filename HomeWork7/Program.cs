using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] msv = new int[] { 4, 5, 9, 1, 3, 2, 8, 12, 100 };
            Console.Write("Ряд для сортировки: ");
            foreach (int element in msv)
            {
                Console.Write($"\t {element}");
            }

            for (int i = 0; i < msv.Length - 1; i++)
            {
                bool replace = false;
                for (int j = 0; j < msv.Length - i - 1; j++)
                {
                    if (msv[j] > msv[j + 1])
                    {
                        int temp = msv[j];
                        msv[j] = msv[j + 1];
                        msv[j + 1] = temp;
                        replace = true; // за проход была минимум одна перестановка
                    }
                }
                if (replace == false)
                {
                    break;
                }
            }
            Console.Write("\n\nОтсортированный ряд: ");
            foreach (int element in msv)
            {
                Console.Write($"\t {element}");
            }

            Console.ReadKey();
        }
    }
}
