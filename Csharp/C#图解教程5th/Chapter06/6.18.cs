
class A
{
    public long AddValue(int a, int b) {return a+b; }
    public long AddValue(int c, int d, int e) {return (c+d+e); }
    public long AddValue(float f, float g) {return (long)(f+g); }
    public long AddValue(long h, long g) {return (h+g); } 
    
}

class B
{
    public long AddValue(long a, long b) {return a+b; }
    //public int AddValue(long c, long d) {return (c+d); } // 重载
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        B b = new B();
        Console.WriteLine(a.AddValue(1,2));
        Console.WriteLine(a.AddValue(1,2,3));
        Console.WriteLine(a.AddValue(1.0f,2.0f));
        Console.WriteLine(a.AddValue(1L,2L));
        Console.WriteLine(b.AddValue(1L,2L));
        Console.WriteLine(b.AddValue(1L,2));
    }
}