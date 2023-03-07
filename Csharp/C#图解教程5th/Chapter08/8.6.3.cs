class MyBaseClass
{
    private int _myInt = 5;
    virtual public int MyProperty
    {
        get { return _myInt; }
        set { _myInt = value; }
    }
}

class MyDerivedClass : MyBaseClass
{
    private int _myInt = 10;
    override public int MyProperty
    {
        get { return _myInt; }
    }
}

class Program
{
    static void Main()
    {

        MyBaseClass mybc = new();
        MyDerivedClass derived = new MyDerivedClass();
        MyBaseClass mybc2 = (MyBaseClass)derived;

        Console.WriteLine(mybc.MyProperty);
        Console.WriteLine(derived.MyProperty);
        Console.WriteLine(mybc2.MyProperty);

    }
}
