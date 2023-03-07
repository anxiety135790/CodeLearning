interface IIfc1 { void PrintOut(string s); }
interface IIfc2 {void PrintOut(string t);}
interface IIFc3 { void PrintOut(string d); }

class MyClass : IIfc1, IIfc2, IIFc3
{
    public void PrintOut(string s)
    {
        Console.WriteLine($"Calling through: {s}");
    }
}

class Program
{
    static void Main()
    {
        MyClass mc = new MyClass();
        mc.PrintOut("object");
    }
}