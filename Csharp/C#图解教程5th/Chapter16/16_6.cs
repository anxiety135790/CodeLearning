interface IDataRetrieve { int GetData(); }
interface IDataStote { void SetData (int x); }

class MyData : IDataRetrieve, IDataStote
{
    int Mem1;
    public int GetData() { return Mem1;}
    public void SetData( int x ) { Mem1 = x;}
}

class Program
{
    static void Main()
    {
        MyData data = new MyData();
        data.SetData( 5);
        Console.WriteLine($"Value = { data.GetData()}");
    }
}