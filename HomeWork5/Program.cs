using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк первой матрицы: ");
            int rowsFirst = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов первой матрицы: ");
            int columnsFirst = Convert.ToInt32(Console.ReadLine());


            int rowsSecond = columnsFirst; //Жестко задаем, что матрицы согласованы
            Console.Write($"Число строк второй матрицы равно: {rowsSecond}\n");
            Console.Write("Введите количество столбцов второй матрицы: ");
            int columnsSecond = Convert.ToInt32(Console.ReadLine());


            int[,] firstMatrix = new int[rowsFirst, columnsFirst];
            int[,] secondMatrix = new int[rowsSecond, columnsSecond];

            Console.WriteLine("\n Первая матрица");

            for (int i = 0; i < rowsFirst; i++)
            {
                for (int j = 0; j < columnsFirst; j++)
                {
                    firstMatrix[i, j] = i * columnsFirst + j;
                    Console.Write($"{firstMatrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Вторая матрица");

            for (int j = 0; j < rowsSecond; j++) // Использую j чтобы было более понятно что матрицы согласованны
            {
                for (int m = 0; m < columnsSecond; m++)
                {
                    secondMatrix[j, m] = j * columnsSecond + m;
                    Console.Write($"{secondMatrix[j, m]} \t");
                }
                Console.WriteLine();
            }

            int[,] resultMatrix = new int[rowsFirst, columnsSecond];

            Console.WriteLine("\n Результат перемножения двух матриц");

            for (int i = 0; i < rowsFirst; i++) // i так как числом строк результата, будет число строк первой матрицы
            {
                for (int m = 0; m < columnsSecond; m++) // m так как числом столбцов результата, будет число столбцов второй матрицы
                {
                    for (int j = 0; j < rowsSecond; j++)
                    {
                        resultMatrix[i, m] += firstMatrix[i, j] * secondMatrix[j, m];
                    }
                    Console.Write($"{resultMatrix[i, m]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
