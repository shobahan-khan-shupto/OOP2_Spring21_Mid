using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;

        public int GetX()
        {
            return this.x;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetY()
        {
            return this.y;
        }

        public void SetY(int y)
        {
            this.y = y;
        }
        public int GetZ()
        {
            return this.z;
        }

        public void SetZ(int z)
        {
            this.z = z;

        }
        public void TestTriangle()
        {
            if (x == y && y == z)
                Console.WriteLine("Equilateral Triangle");


            else if (x == y || y == z || z == x)
                Console.WriteLine("Isoceles Triangle");


            else
                Console.WriteLine("Scalene Triangle");

        }
        public void ShowTriangleInfo()
        {
            Console.WriteLine("Triangle Info:");
            Console.WriteLine(" Value of X: {0}", this.GetX());
            Console.WriteLine("Value of Y: {0}", this.GetY());
            Console.WriteLine("Value of Z: {0}", this.GetZ());
        }
    }
}
    
