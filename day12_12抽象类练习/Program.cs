using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12_12抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用多态求矩形的面积和周长，圆形的面积和周长
            Shape shape = new Circle(5);
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();
            Console.WriteLine("这个形状的面积是{0}，周长是{1}。",area,perimeter);
            Shape shape1 = new Square(3, 4);
            double area1 = shape1.GetArea();
            double perimeter1 = shape1.GetPerimeter();
            Console.WriteLine("这个矩形的面试是{0}，周长是{1}。",area1,perimeter1);
            Console.ReadKey();

        }
    }


    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Circle : Shape
    {
        private double _r;

        public double R
        {
            get
            {
                return _r;
            }

            set
            {
                _r = value;
            }
        }
        public Circle(double r)
        {
            this.R = r;
        }

        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetPerimeter()
        {
            return Math.PI * this.R * 2;
        }
    }


    public class Square : Shape
    {
        private double _height;
        private double _width;

        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public Square(double height,double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double GetArea()
        {
            return this.Height * this.Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (this.Height + this.Width);
        }
    }
}
