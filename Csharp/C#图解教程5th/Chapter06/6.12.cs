using System;
class MyClass
{
    public int Val = 20;
}

class Program
{
    //summary: 传递引用类型参数
    //param: ref MyClass f1, ref int f2
    //return: void

    static void Mymethod(ref MyClass f1, ref int f2)
    {
        f1.Val = f1.Val + 5; // f1.Val = 25
        f2 = f2+5;      // f2 = 15
        Console.WriteLine("f1.Val = {0}, f2 = {1}", f1.Val, f2);
    }


    static void Main(string[] args) // Main函数
    {   
        MyClass a1 = new MyClass(); // a1.Val = 20
        int a2 = 10;    
        Mymethod(ref a1, ref a2);   // f1.Val = 25, f2 = 15
        Console.WriteLine("a1.Val = {0}, a2 = {1}", a1.Val, a2);
    }
    
}