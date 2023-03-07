 class MyClass
 {
    public void ListInts(params int[] inVals)
    {
        if ((inVals != null) && (inVals.Length != 0))
        {
            for(int i = 0; i < inVals.Length; i++)
            {
                inVals[i] = inVals[i] * 10;
                Console.WriteLine("inVals[{0}] = {1}", i, inVals[i]);
            }

        }
    }
    
    
 }

 class Program
 {
    static void Main()
    {
        int first = 5, second = 6, third = 7; //
        MyClass mc = new MyClass();
        mc.ListInts(first, second, third);
        Console.WriteLine("first = {0}, second = {1}, third = {2}", first, second, third);        
    }

 }
