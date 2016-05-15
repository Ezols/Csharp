using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class Shape
    {
        abstract public double Area();
        abstract public double Perimeter();
        public double AreaDiff(Shape rectangle)
        {
            return this.Area() - rectangle.Area();
        }
    }

    class Circle : Shape
    {
        protected double diameter { get; set; }
        protected double perimeter { get; set; }

        public Circle(double diameter)
        {
            this.diameter = diameter;
            this.perimeter = diameter * Math.PI;
        }

       override public double Area()
        {
            return Math.PI * Math.Pow(this.diameter / 2, 2);
        }

       override public double Perimeter()
        {
            return this.perimeter;
        }
    }
    class Square : Rectangle
    {
        public Square(double size) : base(size, size)
        {
          
        }
    }
    class Rectangle : Shape
    {
        protected double height { set; get; }
        protected double width { set; get; }
        protected double perimeter { set; get; }
        protected double area { get; set; }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
            this.perimeter = (height + width) * 2;
            this.area = height * width;
        }

        override public double Area() 
        {
            return this.area;
        }

        override public double Perimeter()
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

            Console.WriteLine("Renctangle area = " + rectangle2.Area());
            Console.WriteLine("Area diff. " + rectangle.AreaDiff(rectangle2));
            Console.WriteLine("Area diff. " + rectangle2.AreaDiff(rectangle));

            Square square = new Square(10);
            Square square2 = new Square(5);
            Console.WriteLine("Square area = " + square.Area());
            Console.WriteLine("Square2 perimeter = " + square2.Perimeter());

            Circle circle = new Circle(20);
            Console.WriteLine("Area of circle = " + circle.Area());
            Console.WriteLine("Perimeter of circle = " + circle.Perimeter());

            Console.WriteLine("Rectangel and Circle area diff. " + rectangle.AreaDiff(circle)); // Polymorfism
        }
    }
}
