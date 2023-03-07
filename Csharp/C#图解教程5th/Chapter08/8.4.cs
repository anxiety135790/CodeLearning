class SomeClass
{
    public string Field1 = "SomeClass Field1";
    public void Method1(string value)
    {
        Console.WriteLine($"SomeClass Method1: {value}");
    }
}

class OtherClass : SomeClass    // 继承SomeClass
{
    new public string Field1 = "OtherClass Field1"; // 使用new关键字,隐藏SomeClass的Field1
    new public void Method1(string value) // 使用new关键字,隐藏SomeClass的Method1
    {
        Console.WriteLine($"OtherClass Method1: {value}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        OtherClass oc = new OtherClass();
        oc.Method1(oc.Field1); // 调用OtherClass的Method1


    }
}