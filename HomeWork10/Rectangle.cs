using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    class Rectangle
    {
        int _firstSide;
        int _secondSide;
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
        public int SecondSide
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

        public Rectangle(int firstSide, int secondSide)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
        }

        public int Sqr()
        {
            return this.FirstSide * this.SecondSide;
        }
    }
}
