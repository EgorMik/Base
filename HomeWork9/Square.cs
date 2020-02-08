using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Square
    {
        int _firstSide;
        public int FirstSide
        {
            get
            {
                return _firstSide;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    _firstSide = value;
                }
            }
        }

        public Square(int side)
        {
            this.FirstSide = side;
        }

        public int Sqr()
        {
            return this.FirstSide * this.FirstSide;
        }

    }
}
