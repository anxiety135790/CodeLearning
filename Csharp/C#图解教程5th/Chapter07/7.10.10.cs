using System;
using static ConsoleTestApp.Trival;

namespace ConsoleTestApp
{
    class Trival
    {
        public static int MyValue { get; set; }

        public void PrintValue()    // 无参数，无返回值
        {
            System.Console.WriteLine("MyValue: {0}", MyValue);
        }
    }

    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Initial value: {0}", Trival.MyValue);
            Trival.MyValue = 10;
            System.Console.WriteLine("After set: {0}", Trival.MyValue);
            MyValue = 20;
            System.Console.WriteLine("After set: {0}", MyValue);
            Trival t = new Trival();
            
            t.PrintValue();

        }
    }
}
