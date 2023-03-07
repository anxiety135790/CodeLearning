interface IIfc1
{
    void PrintOut(string s);
}

class MyClass: IIfc1
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
        mc.PrintOut("object");

        IIfc1 ifc =(IIfc1)mc;
        ifc.PrintOut("interface");
    }
}