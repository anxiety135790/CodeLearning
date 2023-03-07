class MyBaseClass
{
    virtual public void Print()
    {
        Console.WriteLine("This is the base class.");
    }
}

class MyDerivedClass : MyBaseClass
{
    override public void Print()
    {
        Console.WriteLine("This is the derived class.");
    }
}

class SecondDerived : MyDerivedClass
{
    override public void Print()
    {
        Console.WriteLine("This is the second derived class.");
    }
}

class ThirdDerived : MyDerivedClass
{
    new public void Print()
    {
        Console.WriteLine("This is the second derived class.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ThirdDerived td = new ThirdDerived();
        SecondDerived sd = new SecondDerived();
        MyBaseClass mybc = (MyBaseClass)sd;
        MyBaseClass mybc2 = (MyBaseClass)td;
    
        mybc.Print();
        sd.Print();
        mybc2.Print();

    }
}