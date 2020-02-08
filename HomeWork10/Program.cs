using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rct1 = new Rectangle(-20, 30);
            int squareOfRectangle = rct1.Sqr();
            Square sqr1 = new Square(10);
            int squareOfSquare = sqr1.Sqr();
        }
    }
}
