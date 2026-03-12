using System;
using System.Buffers;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Square squar = new Square(4, "yellow");
        Rectangle rect = new Rectangle(2, 4, "blue");
        Circle circ = new Circle(10, "red");
        List<Shape> lista = new List<Shape>();
        lista.Add(squar);
        lista.Add(rect);
        lista.Add(circ);

        foreach (Shape shape in lista)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}