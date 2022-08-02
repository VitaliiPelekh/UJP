using System;
using System.Collections.Generic;

namespace Hw3
{
    internal class Program
    {
        public abstract class Shape : IComparable<Shape>
        {
            private string name;
            public string Name {
                get { return name; }
                set { name = value; }
            }
            public Shape(string name)
            {
                this.name = name;
            }
            public abstract double Area();
            public abstract double Perimeter();
            public override string ToString()
            {
                return $"Shape name: {name}";
            }
            public virtual void Output()
            {
                Console.WriteLine(ToString());
            }
            public int CompareTo(Shape other)
            {
                return this.Area().CompareTo(other.Area());
            }
        }

        public class Circle : Shape
        {
            private double radius;
            public double Radius
            {
                get { return radius; }
                set { radius = value; }
            }

            public Circle(string name, double radius) : base(name)
            {
                this.radius = radius;
            }
            public override double Area() => Math.PI * Math.Pow(radius, 2);
            public override double Perimeter() => 2 * Math.PI * radius;
            public override string ToString()
            {
                return base.ToString() + $"\nShape radius: {radius}";
            }
            public override void Output()
            {
                Console.WriteLine(ToString());
            }
        }

        public class Square : Shape
        {
            private double side;
            public double Side
            {
                get { return side; }
                set { side = value; }
            }

            public Square(string name, double side) : base(name)
            {
                this.side = side;
            }
            public override double Area() => Math.Pow(side, 2);
            public override double Perimeter() => 4 * side;
            public override string ToString()
            {
                return base.ToString() + $"\nShape side: {side}";
            }
            public override void Output()
            {
                Console.WriteLine(ToString());
            }
        }

        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Random rnd = new Random();
            const int COUNT = 4;
            int randNum;
            double value;
            string name;

            do
            {
                Console.WriteLine($"\nEnter data of {shapes.Count + 1} shape: ");
                randNum = rnd.Next(1, 3);
                if (randNum == 1) // circle
                {
                    Console.Write("Circle name: ");
                    name = Console.ReadLine();
                    Console.Write("Circle radius: ");
                    value = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(name, value));
                }
                else if (randNum == 2) // square
                {
                    Console.Write("Square name: ");
                    name = Console.ReadLine();
                    Console.Write("Square radius: ");
                    value = double.Parse(Console.ReadLine());
                    shapes.Add(new Square(name, value));
                }
                else
                {
                    Console.WriteLine("\nError while generating random integers");
                }
            } while(shapes.Count < COUNT);

            Console.WriteLine($"\n\nEntered shapes:");
            foreach (Shape shape in shapes)
            {
                shape.Output();
                Console.WriteLine($"Perimeter: {shape.Perimeter()}\nArea: {shape.Area()}\n");
            }

            Console.WriteLine("\nShape with the largest perimeter:");
            string largestShapeName = "";
            double largestPerimeter = 0;

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() > largestPerimeter)
                {
                    largestPerimeter = shapes[i].Perimeter();
                    largestShapeName = shapes[i].Name;
                }
            }
            Console.WriteLine($"Name: {largestShapeName}\nPerimeter: {largestPerimeter}");

            Console.WriteLine("\n\nSort by area:");

            shapes.Sort(delegate (Shape area1, Shape area2)
            {
                return area1.Area().CompareTo(area2.Area());
            });
            foreach (Shape shape in shapes)
            {
                shape.Output();
                Console.WriteLine($"Perimeter: {shape.Perimeter()}\nArea: {shape.Area()}\n");
            }

            Console.WriteLine("\n\nSort by perimeter:");
            shapes.Sort();
            foreach (Shape shape in shapes)
            {
                shape.Output();
                Console.WriteLine($"Perimeter: {shape.Perimeter()}\nArea: {shape.Area()}\n");
            }
        }
    }
}
