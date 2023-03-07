class MyClass
{
    public int Calc(int a, int b, int c)
    {
        //return a+b+c;
        return (a + b) * c;
    }

    double GetCylinderVolume(double radius, double height)
    {
        return Math.PI * radius * radius * height;
    }

    static void Main(string[] args)
    {
        double volume;
        MyClass mc = new MyClass();
        int result = mc.Calc(1,2,3);
        //Console.WriteLine("{0}", result);
        int r0 = mc.Calc(4, 3, 2); //位置参数
        int r1 = mc.Calc(4,b: 3, c: 2); //位置参数和命名参数
        int r2 = mc.Calc(4, c: 2, b: 3); //交换了参数的顺序
        int r3 = mc.Calc(c: 2, b: 3, a: 4); //所有哦都是命名参数
        int r4 = mc.Calc(c: 2, b: 1+2, a: 3+1); //命名参数表达式
        volume = mc.GetCylinderVolume(2, 3);
        volume = mc.GetCylinderVolume(3,height: 4);
        

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", r0, r1, r2, r3, r4);
    }
}