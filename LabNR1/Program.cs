using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Square : Rectangle
    {
        public Square(int size) : base(size, size)
        {
          
        }
    }
    class Rectangle
    {
        protected int height { set; get; }
        protected int width { set; get; }
        protected int perimeter { set; get; }
        protected int area { get; set; }

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
            this.perimeter = (height + width) * 2;
            this.area = height * width;
        }

        public int Area() 
        {
            return this.area;
        }

        public int Perimeter()
        {
            return this.perimeter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 30); //instances
            Rectangle rectangle2 = new Rectangle(5, 15);
            Console.WriteLine("Renctagle area = " + rectangle.Area());
            Console.WriteLine("Renctangle perimeter = " + rectangle2.Perimeter());

            Square square = new Square(10);
            Square square2 = new Square(5);
            Console.WriteLine("Square area = " + square.Area());
            Console.WriteLine("Square2 perimeter = " + square2.Perimeter());
        }
    }
}
