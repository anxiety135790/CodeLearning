using System;
using static System.Console;

class MyClass
{
    public int Val = 20;
}

class Program
{
    static void Mythod(out MyClass f1, out int f2) // out参数,输出类型参数 
    {
        //summary: 传递引用类型参数
        //param: ref MyClass f1, ref int f2
        //return: void
        f1 = new MyClass();
        f1.Val = 25;
        f2     = 15;
    }

    static void Main(string[] args)
    {
        MyClass a1 = new MyClass();
        int a2 ;
        Mythod(out a1, out a2);
        WriteLine($"a1.Val = {a1.Val}, a2 = {a2}");
    }   

}

