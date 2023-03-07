using System;
class Program
{
    static void MethodA(int par1, int par2)
    {
        Console.WriteLine("MethodA: {0}, {1}", par1, par2);
        MethodB(11, 18); //调用MethodB
        Console.WriteLine("Exit MethodA");
    }

    static void MethodB(int par1, int par2)
    {
        Console.WriteLine("MethodB: {0}, {1}", par1, par2);
        Console.WriteLine("Exit MethodB");
    }

    static void Main()
    {
        Console.WriteLine("Enter Main");
        MethodA(15, 30); //调用MethodA
        Console.WriteLine("Exit Main");
    }

}