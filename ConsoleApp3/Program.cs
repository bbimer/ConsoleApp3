using GClass;
internal class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Console.WriteLine($"Name: {triangle.Name}; P = {triangle.GetPerimeter()}; S = {triangle.GetArea()}");

        Cube cube = new Cube(7);
        Console.WriteLine($"\nName: {cube.Name}; P = {cube.GetPerimeter()}; S = {cube.GetArea()}");

        Rhombus rhombus = new Rhombus(6, 7);
        Console.WriteLine($"\nName: {rhombus.Name}; P = {rhombus.GetPerimeter()}; S = {rhombus.GetArea()}");

        Rectangular rectangular = new Rectangular(6, 7);
        Console.WriteLine($"\nName: {rectangular.Name}; P = {rectangular.GetPerimeter()}; S = {rectangular.GetArea()}");
    }
}
