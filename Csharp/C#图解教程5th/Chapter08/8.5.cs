class SomeClass
{
    public string Field1 = "Field1 -- In the base class";

}

class OtherClass : SomeClass
{
    new public string Field1 = "Field -- In the derived class";

    public void PrintField1()
    {
        System.Console.WriteLine(Field1);   //Field1表示派生类的Field1
        System.Console.WriteLine(base.Field1); //base.Field1表示基类的Field1,base表示基类
    }
}

class Program
{
    static void Main(string[] args)
    {
        OtherClass oc = new OtherClass(); //创建派生类的实例
        oc.PrintField1(); //输出派生类的Field1和基类的Field1
    }
}