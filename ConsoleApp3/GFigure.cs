using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GClass
{
    abstract class GFigure
    {
        public string Name { get; set; }

        public abstract double FArea();
        public abstract double FPerimeter();

        void print()
        {
            Console.WriteLine($"Figure: {Name}");
            Console.WriteLine($"Area: {FArea}");
            Console.WriteLine($"Perimeter: {FPerimeter}\n");
        }
    }

    // Трикутник, Квадрат, Ромб, Прямокутник, Паралелограм, Трапеція, Коло, Еліпс
    class Triangle : GFigure
    {

    }

    class Cube : GFigure
    { 
    
    }

    class Rhombus : GFigure
    {
    
    }

    class Rectangular : GFigure
    {

    }

    class Parallelogram : GFigure
    {

    }

    class Trapezoid : GFigure
    {

    }

    class Circle : GFigure
    {

    }

    class Ellipse : GFigure
    {

    }
}
