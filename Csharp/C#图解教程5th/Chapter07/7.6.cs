class X
{
    static public int A;    // Declare a static field
    static public void PrintValA()  // Declare a static method
    {
        Console.WriteLine("A = {0}", A);
    }
}

class Program
{
    static void Main()
    {
        X.A = 1;    // Set the value of A
        X.PrintValA();  // Call the static method PrintValA()
    }
}