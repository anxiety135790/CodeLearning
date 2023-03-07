using System.Diagnostics;

using static System.Console;
using static System.Diagnostics.Process;

static void MethodA()
{
    //summary: MethodA will be executed by a thread
    //         MethodA will write 5 dots to the console
    //         MethodA will sleep for a random time between 0 and 2 seconds
    //         MethodA will add an A to the Messages property of the SharedObjects class    
    for (int i = 0; i < 5; i++)
    {
        Thread.Sleep(SharedObjects.random.Next(2000));
        SharedObjects.Messages += "A";
        Write(".");
    }
}

static void MethodB()
{
    for (int i = 0; i < 5; i++)
    {
        //summary: MethodB will be executed by a thread
        //         MethodB will write 5 dots to the console
        //         MethodB will sleep for a random time between 0 and 2 seconds
        //       MethodB will add a B to the Messages property of the SharedObjects class
        Thread.Sleep(SharedObjects.random.Next(2000));
        SharedObjects.Messages += "B";
        Write(".");
    }
}


WriteLine(value: "watitting for both tasks to complete.");
Stopwatch watch = Stopwatch.StartNew(); // start the stopwatch  

Task taska = Task.Factory.StartNew(MethodA);// start the taskA
Task taskb = Task.Factory.StartNew(MethodB); // start the taskB

Task.WaitAll(taska, taskb); // wait for both tasks to complete

WriteLine();
WriteLine($"Messages: {SharedObjects.Messages}");
WriteLine($"Elapsed time: {watch.ElapsedMilliseconds:N0} ms");


static class SharedObjects 
{
    
    public static Random random = new Random();
    public static string Messages = ""; // shared resource
}



