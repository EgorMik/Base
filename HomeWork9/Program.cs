using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            Square firstSquare = new Square(10);
            int squareSquare = firstSquare.Sqr();
            Rectangle firstRectangle = new Rectangle(20, 50);
            int squareRectangle = firstRectangle.Sqr();
        }
    }
}
