using System.Runtime.InteropServices;
using System.Text;
using GClass;
internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Triangle triangle = new Triangle(3, 4, 5);
        triangle.print();

        Cube cube = new Cube(7);
        cube.print();

        Rhombus rhombus = new Rhombus(6, 7);
        rhombus.print();

        Rectangular rectangular = new Rectangular(6, 7);
        rectangular.print();

        CFigure comp = new CFigure(3);

        comp.AddFigure(new Triangle(3, 4, 5));
        comp.AddFigure(new Cube(7));
        comp.AddFigure(new Trapezoid(7, 8, 9));
        comp.print();
    }
}
