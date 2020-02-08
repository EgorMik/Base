using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Rectangle:Square
    {
        int _secondSide;
        int SecondSide
        {
            get
            {
                return _secondSide;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    _secondSide = value;
                }
            }
        }

        public Rectangle(int firstSide, int secondSide) : base(firstSide)
        {
            this.SecondSide = secondSide;
        }

        public int Sqr()
        {
            return base.FirstSide * this.SecondSide;
        }
    }
}
