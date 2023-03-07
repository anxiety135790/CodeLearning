class Publiser
{
    public event EventHandler SimpleEvent;

    public void RaiseTheEvent()
    {
        SimpleEvent( this, null );
    }
}

class Subscriber
{
    public void MethodA( object o, EventArgs e) {Console.WriteLine("AAA");}

    public void MethodB( object o, EventArgs e) {Console.WriteLine("BBB");}

    public void MethodC( object o, EventArgs e) { Console.WriteLine("CCC");}
    
}

class Program
{
    static void Main()
    {
        Publiser p = new Publiser();
        Subscriber s = new Subscriber();

        p.SimpleEvent += s.MethodA;
        p.SimpleEvent += s.MethodB;
        p.SimpleEvent += s.MethodB;
        p.SimpleEvent += s.MethodC;
        p.RaiseTheEvent();

        Console.WriteLine("\r\nRemove MethodB");
        p.SimpleEvent -= s.MethodB; //Romove the last MehodB
        p.RaiseTheEvent();
    }
}