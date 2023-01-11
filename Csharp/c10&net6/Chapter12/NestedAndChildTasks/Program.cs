using static System.Console;


Task outerTask = Task.Factory.StartNew(OuterMethod);
outerTask.Wait();
WriteLine("Console app is stopping.");

static void OuterMethod()
{
    WriteLine("Outer method startig ...");
    Task innerTask = Task.Factory.StartNew(innerMethod,TaskCreationOptions.AttachedToParent);
    WriteLine("Outer method stoping.");
}

static void innerMethod()
{
    WriteLine("Inner method starting ...");
    Thread.Sleep(2000);
    WriteLine("Inner method stoping.");
}