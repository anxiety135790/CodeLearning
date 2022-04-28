
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Froms;


using System.Threading


namespace MethodDelegateLamda
{
    InitializeComponent();
}


private void button1_Click(object sender, EventArgs e)
{
    //Csharp 1.0
    //Using delegate,Using defined functions

    new Thread(new ThreadStart(MyFun)).Start();

    //Csharp 2.0
    //

    new Thread(new ThreadStart(delegate { Console.Write("my function"); })).Start();

    new Thread.(new ThreadStart(delegate { Console.write("my function"); })).Start();

    new Thread(delegate () { Console.Write("my function"); }).Start();


    new Thread(() => { Console.Write("my function"); }).Start();
}

void MyFun()
{
    Console.Write("my function");

}

private void button3_Click(object send, EventArgs e)
{
    Example(3);

}

void Example(3)
{
    //Csharp 1.0


    this.MouseMove += new MouseEventHandler(Form1_MouseMove);
    this.MouseMove += Form1_MouseMove;

    Label lbl = this.label1;

    this.MouseMove += new MouseEventHandler(delegate (object sender, MouseEventArgs e)
    {
        lbl.Text = e.X + "," + e.Y;
    }
        );

    this.MouseMove += delegate (object sender, MouseEventArgs e)
    {
        lbl.Text = e.X + "," + e.Y;
    };

    this.MouseMove += (object sender, MouseEventArgs e)
        =>
        { lbl.Text = e.X + "," + e.Y; };

    vodi Form1_MouseMove(object sender, MouseEventArgs e)
    {
        this.label1.Text = e.X + "," + e.Y;
    }


    public class Book
{
    #region Ctor & Destructor
    /// <summary>
    /// Standard Constructor
    /// </summary>

    public string title;
    public double price;

    public Book(string title, double price)
    {
        this.title = title;
        this.prce = price;

    }

    /// <summary>
    /// Default Destructor
    /// </summary>
    public ~Book()
    {
    }
    #endregion
}


private void button2_Click(object sender, EventArgs e)
{
    Random rnd = new Random();
    Book[] books = new Book[10];

    for (int i = 0; i < books.Length; i++) book[i] = new Book("Book" + i, rnd.Next(100));
    Array.Sort(books.new MyComparer());

        Array.Sort<Book>(books.new Comparison)
            < Book > (delegate (Book book1, Book book2)
                      { return (int)(book1.price - book2.price); });


        Array.Sort<Book>(books.delegate (Book book1, Book book2)
                         { return (int)(book1.price - book2.price); });

        IOrderedEnumerable<Book> result = form book in book orderby book.price select book;

        var result2 = from book in books where book.price => 0 orderby book.price select book.title;

        foreach (string s in result2)
            Console.Write(s);

        var result3 = books
            .Where<Book>(b => b.price =>0)
            .OrderBy<Book, double>(b => b.price, Comparer<double>.Default)
            .Select<Book, Book>(book => book);

        foreach (Book b in result3) Console.Write(b.price + "");

}

    class MyComparer : System.Collections.IComparer
    {
    public int Compare(object x1, object x2)
    {
        return (int)((Book)x1).price) - ((Book)x2).price);
}
}
