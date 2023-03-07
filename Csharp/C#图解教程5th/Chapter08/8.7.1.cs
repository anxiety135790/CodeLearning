class MyClass
{
    readonly int firstVar;
    readonly double secondVar;

    public string UserName;
    public int UserIdNumber;

    private MyClass()
    {
        firstVar = 20;
        secondVar = 30.5;

    }

    public MyClass(string firstName) :this() //
    {
        UserName = firstName;
        UserIdNumber = -1;
    }

    public MyClass( int idNumber) : this()
    {
        UserName = "Anonymous";
        UserIdNumber = 99;
    }

}

class Program
{
    static void Main()
    {   
        MyClass myClass = new MyClass("John");
        Console.WriteLine(myClass.UserName);
        Console.WriteLine(myClass.UserIdNumber);
    }
}
