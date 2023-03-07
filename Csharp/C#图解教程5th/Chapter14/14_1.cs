delegate void MyDel(int value); // 声明一个委托类型

class Program
{
    void PrintLow(int value)
    {
        Console.WriteLine($"{value} - Low Value");
    }

    void PrintHigh(int value)
    {
        Console.WriteLine($"{value} - High Value");
    }

    static void Main()
    {
        Program program = new Program();

        MyDel del;  // 申明一个委托变量

        Random rand = new Random();
        int randomValue = rand.Next( 99 );

        del = randomValue < 50
            ? new MyDel(program.PrintLow)   //"?", is "=="
            : new MyDel(program.PrintHigh); //":", not "=="

        del(randomValue);
    }
}
