class X
{
    //public const double PI = 3.1415926;   
    public const double PI = Math.PI;// Declare a constant field
}

class Program
{
    static void Main()
    {
        Console.WriteLine("PI = {0}", X.PI);    // Call the constant field PI
    }
}