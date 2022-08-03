// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.WriteLine("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Enter Height: ");
int height = Convert.ToInt32(Console.ReadLine());



var cube = new Cube(width, height, length);

var triangle = new Triangle();
var triangle2 = new Triangle(){ Length = length, Height = height, Hypotenuese = 10 };
var triangle1 = new Triangle(10);
var triangle3 = new Triangle(10, height, length);

var rectangle = new Rectangle() { Length = length, Width = width};

/*
cube.Length = length;
cube.Width = width;
cube.Height = height;

triangle.Length = length;
triangle.Height = height;

rectangle.Length = length;
rectangle.Width = width;
*/

Console.WriteLine("Cube Area is: " + cube.GetArea());
Console.WriteLine("Cube Volume is: " + cube.getVolume());

Console.WriteLine("Tringle Area is: " + triangle.GetArea());
Console.WriteLine("Tringle Area is: " + triangle2.GetArea());
Console.WriteLine("Tringle Area is: " + triangle1.GetArea());
Console.WriteLine("Tringle Area is: " + triangle3.GetArea());

Console.WriteLine("Rectangle Area is: " + rectangle.GetArea());