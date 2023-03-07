/* class Program
{
    static void Main()
    {
        int x = 2;
        ref int y = ref x;

        Console.WriteLine($"x = {x}, y = {y}");
        x=5;
        Console.WriteLine($"x = {x}, y = {y}");
        y=6;
        Console.WriteLine($"x = {x}, y = {y}");
    }
} */


/* class Simple
{
    private int Score = 5;

    public ref int RefToValue() 
    {
        return ref Score;
    }

    public void DisPlay()
    {
        Console.WriteLine($"Score = {Score}");
    }
    
}

class Program
{
    static void Main()
    {
        //summary: ref关键字
        //param: ref int v1Outside
        //return: void
        Simple s = new Simple();
        s.DisPlay();

        ref int v1Outside = ref s.RefToValue();
        v1Outside = 10;
        s.DisPlay();
    }
}    */

using static System.Console;


class Program
{
    static ref int Max(ref int p1, ref int p2)
    {
        if (p1 > p2)
        {
            return ref p1;
        }
        else
        {
            return ref p2;
        }
    }

    static void Main()
    {
        int v1 = 10;
        int v2 = 20;
        WriteLine  ("Start");
        WriteLine  ($"v1 = {v1}, v2 = {v2}");
        
        ref int max = ref Max(ref v1, ref v2);
        WriteLine("After calling Max");
        WriteLine($"v1 = {v1}, v2 = {v2}, max = {max}");

        max++;
        WriteLine("After incrementing max");
        WriteLine($"v1 = {v1}, v2 = {v2}, max = {max}");
    }
}


