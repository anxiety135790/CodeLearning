class MyBaseClass
{
    virtual public void Print() //virtual关键字用于声明虚方法,可以被派生类重写
    {
        System.Console.WriteLine("Base class");
    }


}

class MyDerivedClass : MyBaseClass
{
    override public void Print() //override关键字用于声明重写方法,必须与基类中的方法具有相同的签名
    {
        System.Console.WriteLine("Derived class");
       
    }
}

class Program
{
    static void Main(string[] args)
    {   
        /// <summary>
        ///  1. 重写方法的签名必须与基类中的方法具有相同的签名
        /// 2. 重写方法的访问修饰符必须与基类中的方法具有相同或更大的访问权限
        /// 3. 重写方法的返回类型必须与基类中的方法具有相同的返回类型
        /// 4. 重写方法的异常列表必须与基类中的方法具有相同的异常列表
        /// 5. 重写方法的访问修饰符必须与基类中的方法具有相同或更大的访问权限
        /// </summary>
        /// <returns></returns>

        MyDerivedClass mydc = new MyDerivedClass(); 
        MyBaseClass mybc = (MyBaseClass)mydc;

        mydc.Print();
        mybc.Print();
    }
}