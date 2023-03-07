class MyClass
{
    /*     public int Calc(int a, int b = 3)
        {
            return a + b;
        } */

    /*     static void Main()
        {
            MyClass mc = new MyClass();
            int r0 = mc.Calc(5, 6);
            int r1 = mc.Calc(5);

            Console.WriteLine("{0}, {1}", r0, r1);

        } */

    public int Calc(int a, int b = 3, int c = 4)
    {
        return (a + b) * c;
    }

    double GetCylinderVolume(double radius = 3.0, double height = 4.0)
    {
        return Math.PI * radius * radius * height;
    }

    static void Main()
    {
        double volume;
        MyClass mc = new MyClass();
        int r0 = mc.Calc(a: 5, b: 6); //使用所有的显式值
        int r1 = mc.Calc(a: 5);    //为c使用默认值
        int r2 = mc.Calc(5, c: 6);  //为b和c使用默认值
        int r3 = mc.Calc(5, c: 6, b: 7);
        int r4 = mc.Calc(c: 6, b: 7, a: 5);
        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", r0, r1, r2, r3, r4);


        volume = mc.GetCylinderVolume();
        Console.WriteLine("{0}", volume);
        volume = mc.GetCylinderVolume(3.0, 4.0);
        Console.WriteLine("{0}", volume);
        Console.WriteLine("{0}", volume);
        volume = mc.GetCylinderVolume(3.0);
        Console.WriteLine("{0}", volume);

    }

}
