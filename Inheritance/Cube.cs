// See https://aka.ms/new-console-template for more information
class Cube : Shape, IShape
{
   
    public Cube(int width, int height, int length)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    public double Width { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }

    public double getVolume()
    {
        return Length * Width * Height;
    }
}
