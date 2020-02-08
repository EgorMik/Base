using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            TypicalList<string> array = new TypicalList<string>();

            string[] arr = new string[3000];
            for (int i = 0; i < 3000; i++)
            {
                arr[i] = $"{i}";
            }
            for (int i = 0; i < 2500; i++)
            {
                array.Add($"{i}");
            }
            //array.Clear();
            Console.WriteLine(array.IndexOf($"{1000}"));
            Console.WriteLine(array.IndexOf($"{2500}"));
            Console.WriteLine(array.Contains($"{1000}"));
            Console.WriteLine(array.Contains($"{2500}"));
            array.Insert(100, $"{199}");
            array[10] = $"{105010}";
            string z = array[10];
            string s = array[260];
            array.Remove($"{199}");
            arr.ToString();
            array.CopyTo(arr, 300);
            //array.Clear();
            foreach (string number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
