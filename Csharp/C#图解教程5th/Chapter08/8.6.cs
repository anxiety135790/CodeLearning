class MyBaseClass
{
    public void Print() 
    {
        System.Console.WriteLine("MyBaseClass.Print()");
    }
}

class MyDerivedClass : MyBaseClass
{
    public int var1;

    new public void Print()
    {
        System.Console.WriteLine("MyDerivedClass.Print()");
    }

}

class Program
{
    static void Main(string[] args)
    {
        MyDerivedClass mydc = new MyDerivedClass(); //创建派生类的实例
        MyBaseClass mybc = (MyBaseClass)mydc; //将派生类的实例转换为基类的实例

        mydc.Print(); //输出MyDerivedClass.Print()
        mybc.Print(); //输出MyBaseClass.Print()
        //mybc.var1 = 1; //编译错误: 

    }

}
