using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Point
    {
        int x;
        int y;
        string name;

        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
        {
        }

        public Point(string val1, int val2, int val3)
        {
            this.name = val1;
            this.x = val2;
            this.y = val3;
        }
    }
}
