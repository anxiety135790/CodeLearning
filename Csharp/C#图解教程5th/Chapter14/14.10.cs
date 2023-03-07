delegate void PrintFunction(); //定义一个没有参数和返回值的委托类型
class Test
{
    public void Print1()
    {
        System.Console.WriteLine("Print1 --instance");
    }
    public static void Print2()
    {
        System.Console.WriteLine("Print2 --static");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Test t = new Test(); //创建一个Test类的实例
        PrintFunction pf; //创建一个委托变量

        pf = t.Print1; //将Print1方法赋值给委托

        pf += Test.Print2; //将Print2方法赋值给委托
        pf += t.Print1; //将Print2方法赋值给委托
        pf += Test.Print2; //将Print2方法赋值给委托


        if (null != pf) //判断委托是否为空
        {
            pf(); //调用委托
        }
        else
        {
            System.Console.WriteLine("Delegate is empty");
        }
    }
}