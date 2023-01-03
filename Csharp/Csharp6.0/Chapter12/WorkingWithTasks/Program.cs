using System.Diagnostics;
using static System.Console;

static void OutputThereadInfo()
{
    Thread t = Thread.CurrentThread;

    WriteLine("Thread ID: {0}, 
                Priority: {1},
                Background: {2}, 
                Name: {3},
                t.ManagedThreadId, t.Priority,
                t.IsBackground, t.Name ?? "null");

}

OutputThereadInfo();
Stopwatch timer = Stopwatch.StartNew();

WriteLine("Runing methods synchronously on one thread");
MethodA;
MethodB;
MethodC;


static void MethodA()
{
    WriteLine("Starting Method A...");
    OutputThereadInfo();
    Thread.Sleep(3000);
    WriteLine("Finished Method A.");
}

static void MethodB()
{
    WriteLine("Starting Method B...");
    OutputThereadInfo();
    Thread.Sleep(3000);
    WriteLine("Finished Method B.");
}

static void MethodC()
{
    WriteLine("Starting Method C...");
    OutputThereadInfo();
    Thread.Sleep(3000);
    WriteLine("Finished Method C.");
}