class RightTriangle
{
    public double a = 3, b = 4, c;
    public RightTriangle(double a, double b, double c)
    {
        this.a = a; 
        this.b = b;
        this.c = c;
    }
    public double Area()
    {
        return a * b / 2;
    }
    public double Perimeter()
    {
        return a + b + c;
    }
    public double Hypotenuse()
    {
        return c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        RightTriangle rt = new RightTriangle(3, 4, 5);
        System.Console.WriteLine("Area: {0}", rt.Area());
        System.Console.WriteLine("Perimeter: {0}", rt.Perimeter());
        System.Console.WriteLine("Hypotenuse: {0}", rt.Hypotenuse());
    }
}