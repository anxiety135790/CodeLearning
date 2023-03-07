interface IIfc1 { void PrintOut(string s);}
interface IIFc2 { void PrintOut(string s);}

class MyClass : IIfc1,IIFc2 
{
    public void PrintOut(string s)
    {
        Console.WriteLine($"Calling through: { s }");
    }
}

class Program
{
    static void Main()
    {
        MyClass mc = new MyClass();

        IIfc1 ifc1 = (IIfc1) mc;
        IIFc2 ifc2 = (IIFc2) mc;

        mc.PrintOut("object");

        ifc1.PrintOut("interface 1");
        ifc2.PrintOut("interface 2");
    }
}