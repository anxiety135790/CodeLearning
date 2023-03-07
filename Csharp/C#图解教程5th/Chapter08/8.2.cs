class SomeClass // 定义一个类
{
    public string Field1 = "base class field"; // 定义一个字段
    public void Method1(String value) // 定义一个方法
    {
        System.Console.WriteLine($"base class method, value = {value}");
    }

    class OtherClass : SomeClass // 定义一个派生类
    {
        public string Field2 = "derived class field"; // 定义一个字段
        public void Method2(String value) // 定义一个方法
        {
            System.Console.WriteLine($"derived class method, value = {value}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OtherClass sc = new OtherClass(); // 创建派生类的实例
            sc.Method1( sc.Field1); // 调用基类的方法, 但是参数是基类的字段
            sc.Method1(sc.Field2); // 调用基类的方法, 但是参数是派生类的字段

            sc.Method2(sc.Field1); // 调用派生类的方法, 但是参数是基类的字段
            sc.Method2(sc.Field2); // 调用派生类的方法, 但是参数是派生类的字段

        }
    }
}
