interface IIfc1 { void PrintOut(string s);}
interface IIfc2 { void PrintOut(string s);}

class MyClass : IIfc1,IIfc2 
{
    /// <summary>
    ///  
    /// </summary>
    /// <param name="s"></param>
    void IIfc1.PrintOut(string s) //
    {Console.WriteLine($"IIfc1: { s }");}

     void IIfc2.PrintOut(string s)
    {Console.WriteLine($"IIfc1: { s }");}
}

class Program
{
    static void Main()
    {
        MyClass mc = new MyClass();

        IIfc1 ifc1 = (IIfc1) mc;
        IIfc2 ifc2 = (IIfc2) mc;

        
        ifc1.PrintOut("interface 1");
        ifc2.PrintOut("interface 2");
    }
}