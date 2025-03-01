using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GClass
{
    abstract class GFigure
    {
        public string Name { get; set; }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public void print()
        {
            Console.WriteLine($"Figure: {Name}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}\n");
        }
    }

    // Трикутник, Квадрат, Ромб, Прямокутник, Паралелограм, Трапеція, Коло, Еліпс
    class Triangle : GFigure
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }


        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a) Console.WriteLine("немає такого трикутника");

            Name = "Трикутник";
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;  
        }

        public override double GetArea()
        { 
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public override double GetPerimeter()
        {
            return (sideA + sideB + sideC);
        }
    }

    class Cube : GFigure
    {
        public double sideA { get; set; }

        public Cube(double sideA)
        {
            Name = "Квадрат";
            this.sideA = sideA;
        }

        public override double GetArea()
        {
            return (sideA * sideA);
        }

        public override double GetPerimeter()
        {
            return (sideA * 4);
        }
    }

    class Rhombus : GFigure
    {
        public double d1 { get; set; }
        public double d2 { get; set; }

        public Rhombus(double d1, double d2)
        {
            Name = "Ромб";
            this.d1 = d1;
            this.d2 = d2;
        }

        public override double GetPerimeter()
        {
            return Math.Sqrt(Math.Pow((d1 / 2), 2) + Math.Pow((d2 / 2), 2)) * 4;
        }

        public override double GetArea()
        {
            return (d1 * d2) / 2;
        }
    }

    class Rectangular : GFigure
    {
        public double width {  get; set; }
        public double height { get; set; }

        public Rectangular(double width, double height)
        {
            Name = "Прямоугольник";
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override double GetPerimeter()
        {
            return 2 * (width * height);
        }
    }

    class Parallelogram : GFigure
    {
        public double width { get; set; }
        public double height { get; set; }

        public double sin { get; set; }

        public Parallelogram(double width, double height, int sin)
        {
            Name = "Паралелограм";
            this.width = width;
            this.height = height;
            this.sin = sin;
        }

        public override double GetArea()
        {
            return (width * height);
        }

        public override double GetPerimeter()
        {
            return (2 * ((width + height)/(Math.Sin(sin * Math.PI / 180))));
        }
    }

    class Trapezoid : GFigure
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double height { get; set; }

        public Trapezoid(double sideA, double sideB, double height)
        {
            Name = "Трапеція";
            this.sideA = sideA;
            this.sideB = sideB;
            this.height = height;
        }


        public override double GetArea()
        {
            return (((sideA + sideB) / 2) * height);
        }

        public override double GetPerimeter()
        {
            return (sideA + sideB + 2 * height);
        }
    }

    class Circle : GFigure
    {
        public double radius {  get; set; }

        public Circle(double radius)
        {
            Name = "Коло";
            this.radius = radius;
        }

        public override double GetArea()
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public override double GetPerimeter()
        {
            return (2 * Math.PI * radius);
        }
    }

    class Ellipse : GFigure
    {
        public double d1 { get; set; }
        public double d2 { get; set; }

        public Ellipse(double d1, double d2)
        {
            Name = "Еліпс";
            this.d1 = d1;
            this.d2 = d2;
        }

        public override double GetArea()
        {
            return (Math.PI * d1 * d2);
        }

        public override double GetPerimeter()
        {
            return (Math.PI * (3 * (d1 + d2) - Math.Sqrt((3 * d1 + d2) * (d1 + 3 * d2))));
        }
    }
}
