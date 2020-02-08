using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst1 = new List<int>();
            lst1.Add(10);
            lst1.AddRange(new int[] { 1, 2, 3, 4 });
            ArrayList lst2 = new ArrayList(capacity: 10);
            lst2.AddRange(new string[] { "1dfa", "dasdasd,asd", "daa1112" });
            Stack stck = new Stack();
            stck.Push(10);
            stck.Push("312");
            stck.Pop();
            stck.Push(11);
            stck.Pop();
            stck.Pop();
            Random rnd = new Random();
            Queue que = new Queue();
            que.Enqueue(rnd.Next(0, 10));
            que.Enqueue(rnd.Next(0, 10));
            que.Enqueue(rnd.Next(0, 10));
            que.Enqueue(4);
            que.Dequeue();
            que.Dequeue();

            Console.ReadKey();
        }
    }
}
