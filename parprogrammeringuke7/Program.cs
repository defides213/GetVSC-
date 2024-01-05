// See https://aka.ms/new-console-template for more information
namespace parprogrammeringuke7
{
    public class Program
    {
        public static void Main()
        {
            var circle = new Circle(5, "Circle");
            var square = new Square(10, "Square");
            var rectangle = new Rectangle(5, 10, "Rectangle");
            List<Shape> list = new List<Shape> {circle, square, rectangle};

            foreach (var shape in list)
            {
                Console.WriteLine($"{shape.Name} has {shape.GetPerimeter()} Perimeter \n" +
                                   $"{shape.Name} has {shape.GetAreal()} Area \n");
            }
        }
    }
}
