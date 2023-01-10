using System.Diagnostics;

using static System.Console;


OutputThreadInfo();
Stopwatch timer = Stopwatch.StartNew();

/*
WriteLine("Running methods sysnchronously on one thread.");
MethodA();
MethodB();
MethodC();
*/

/*
WriteLine("Runing methos asynchronously on multiple threads");

Task taskA = new(MethodA);
taskA.Start();

Task taskB = Task.Factory.StartNew(MethodB);

Task taskC = Task.Run(MethodC);

Task[] tasks = {taskA, taskB, taskC};
Task.WaitAll(tasks);
*/

WriteLine("Passing the result of one task as an input into another."); 
Task<string> taskServiceThenSProc = Task.Factory
 .StartNew(CallWebService) // returns Task<decimal>
 .ContinueWith(previousTask => // returns Task<string>
    CallStoredProcedure(previousTask.Result));
WriteLine($"Result: {taskServiceThenSProc.Result}");


WriteLine($"{timer.ElapsedMilliseconds:#, ##0}ms elapsed.");

static void OutputThreadInfo()
{
    Thread t = Thread.CurrentThread;

    WriteLine(
        "Thread Id:{0}, Priority: {1}, Background: {2}, Name: {3}",
        t.ManagedThreadId, t.Priority,
        t.IsBackground, t.Name ?? "null");
        
}

static void MethodA()
{
    WriteLine("Starting Method A ......");
    OutputThreadInfo();
    Thread.Sleep(3000);
    WriteLine("Finished Method A .");

}



static void MethodB()
{
    WriteLine("Starting Method B ......");
    OutputThreadInfo();
    Thread.Sleep(3000);
    WriteLine("Finished Method B .");

}


static void MethodC()
{
    WriteLine("Starting Method C ......");
    OutputThreadInfo();
    Thread.Sleep(3000);
    WriteLine("Finished Method C .");

}

static decimal CallWebService()
{
    WriteLine("");
    OutputThreadInfo();
    Thread.Sleep((new Random()).Next(2000,4000));
    WriteLine("Finished call to web service. ");
    return 89.99M;
}

static string CallStoredProcedure(decimal amount)
{
    WriteLine("");
    OutputThreadInfo();
    Thread.Sleep((new Random()).Next(2000,4000));
    WriteLine(
        "Finished call to stored Procedure.");
    return $"12 products cost more than {amount:C}";  
}