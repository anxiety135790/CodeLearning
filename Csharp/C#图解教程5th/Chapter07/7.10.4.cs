class C1
{
    private int theRealValue = 10;

    public int MyValue
    {
        get
        {
            return theRealValue;
        }
        set
        {
            theRealValue = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C1 c1 = new C1();
            System.Console.WriteLine(c1.theRealValue);
            
            c1.MyValue = 20;
            System.Console.WriteLine(c1.MyValue);

            c1.MyValue = 30;
            System.Console.WriteLine(c1.MyValue);
        
        }
    }
}