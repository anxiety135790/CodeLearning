abstract class AbClass
{
    public void IdentifyBase()
    {
        Console.WriteLine("I am AbClass");
    }

    abstract public void IdentifyDerived();
}

class DerivedClass : AbClass
{
    override public void IdentifyDerived()
    {
        Console.WriteLine("I am DerivedClass");
    }
}

class Program
{
    static void Main()
    {
        //AbClass a = new AbClass();
        //a.IdentifyDerived();

        DerivedClass b = new DerivedClass();
        b.IdentifyBase();
        b.IdentifyDerived();
    }
}
