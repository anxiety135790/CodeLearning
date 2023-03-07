using System;

class MyClass
{
    public int Val = 20;
}
class Program
{
    static void RefAsParameter(ref MyClass f1) // ref参数, 传递引用类型参数
    {
        f1.Val = 50;
        Console.WriteLine($"After memeber assignment:  {f1.Val}");
        f1 = new MyClass();
        Console.WriteLine($"After new object creation: {f1.Val}");
    }
    static void Main(string[] args)
    {
        MyClass a1 = new MyClass();
        Console.WriteLine($"Before method call: {a1.Val}");
        RefAsParameter(ref a1);
        Console.WriteLine($"After method call: {a1.Val}");
    }


}