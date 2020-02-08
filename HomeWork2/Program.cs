using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа, которые будут являться размером сторон кирпича");
            Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите два числа, которые будут являться размером сторон отверстия");
            Console.WriteLine("d=");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("e=");
            int e = Convert.ToInt32(Console.ReadLine());
            if (((d >= a) & (e >= a)) || ((d >= b) & (e >= b)) || ((d >= c) & (e >= c)))
            {
                Console.WriteLine("Размеры кирпича меньше либо равны сторонам отверстия, кирпич пролезет в отверстие");
            }
            else
            {
                Console.WriteLine("Размеры кирпича больше чем отверстие, кирпич не пролезет в отверстие");
            }
            Console.ReadKey();
        }
    }
}
