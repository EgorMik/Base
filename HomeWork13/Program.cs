using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoLinkedList<int> twoLink = new TwoLinkedList<int>();
            twoLink.Add(99);
            for (int i = 0; i < 20; i++)
            {
                twoLink.Add(i + 100);
            }
            int x = twoLink[10];
            twoLink[1] = 5000;
            twoLink.Clear();
            twoLink.Insert(0, 100);
            twoLink.Insert(0, 500);
            twoLink.Insert(1, 1000);
            twoLink.RemoveAt(1);
            twoLink.Insert(2, 1500);
            twoLink.Add(500);
            int y = twoLink.IndexOf(1500);
            bool z = twoLink.Contains(2500);
            twoLink.Remove(500);
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 5000;
            }

            twoLink.CopyTo(array, 10);
            foreach (int element in twoLink)
            {
                Console.WriteLine(element);
            }
        }
    }
    
}
