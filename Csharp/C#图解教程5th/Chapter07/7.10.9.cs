class C1
{
    private int theRealValue = 5;
    public int MyValue
    { 
        get{return theRealValue;}
        set{theRealValue = value;} 
    }

    class Program
    {
        static void Main()
        {
            C1 c1 = new C1();
            System.Console.WriteLine(c1.MyValue);
            c1.MyValue = 10;
            System.Console.WriteLine(c1.MyValue);
        }
    }
}