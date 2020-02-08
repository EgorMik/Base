using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber x = new ComplexNumber(3, 4);
            ComplexNumber y = new ComplexNumber(5, -9);
            ComplexNumber resul;
            resul = x.Summ(y);
            resul.Print();
            resul = y.Dif(x);
            resul.Print();
        }
    }
    public class ComplexNumber
    {
        private int realNum;
        private int imageNum;
        public ComplexNumber(int a, int b)
        {
            realNum = a;
            imageNum = b;

        }
        public void Print()
        {

            Console.WriteLine($"{this.realNum}{((this.imageNum < 0) ? "" : "+")}{this.imageNum}i");

        }
        public ComplexNumber Summ(ComplexNumber y)
        {
            ComplexNumber result = new ComplexNumber(y.realNum + realNum, y.imageNum + imageNum);
            return result;

        }
        public ComplexNumber Dif(ComplexNumber x)
        {
            ComplexNumber result = new ComplexNumber(x.realNum - realNum, x.imageNum - imageNum);
            return result;

        }
    }
}
