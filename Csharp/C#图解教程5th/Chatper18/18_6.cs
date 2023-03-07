static class ExtendHolder
{
    public static void Print<T>(this Holder<T> h)
    {
        T[] vals = h.GetValues();
        Console.WriteLine($"{vals[0]}, {vals[1]}, {vals[2]}");

    }
}

class Holder<T>
{
    T[] values = new T[3];
    public Holder(T v0, T v1, T v2)
    {
        values[0] = v0;
        values[1] = v1;
        //values[2] = v2;
    }

    public T[] GetValues()
    {
        return values;
    }
}

class Program
{
    static void Main()
    {
        var h1 = new Holder<int>(3, 5, 7);
        var h2 = new Holder<string>("first", "second", "third");
        var h3 = new Holder<double>(3.567, 7.891, 2.345);

        h1.Print();
        h2.Print();
        h3.Print();
    }
}