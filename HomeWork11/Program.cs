using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            ListArray array = new ListArray();
            List<int> list = new List<int>();
            for (int i = 0; i < 2500; i++)
            {
                list.Add(i + 1000);
            }

            int[] arr = new int[3000];
            for (int i = 0; i < 3000; i++)
            {
                arr[i] = i;
            }
            for (int i = 0; i < 2500; i++)
            {
                array.Add(i);
            }
            // array.Clear();
            Console.WriteLine(array.IndexOf(1000));
            Console.WriteLine(array.IndexOf(2500));
            Console.WriteLine(array.Contains(1000));
            Console.WriteLine(array.Contains(2500));
            array.Insert(100, 199);
            array[10] = 105010;
            int z = array[10];
            array.Remove(199);
            list.CopyTo(arr, 500);
            array.CopyTo(arr, 300);
            //array.Clear();
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
