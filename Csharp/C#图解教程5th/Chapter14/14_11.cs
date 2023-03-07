 delegate int MyDel();
 class MyClass
 {
    int IntValue = 5;
    public int Add(){ IntValue += 2; return IntValue;}
    public int Sub(){ IntValue -= 3; return IntValue;}
 }

 class Program
 {
    static void Main()
    {
        MyClass mc = new MyClass();
        MyDel mdel = mc.Add;
        mdel += mc.Sub;
        mdel += mc.Add;
        Console.WriteLine($"Value: {mdel()}");
    }
 }