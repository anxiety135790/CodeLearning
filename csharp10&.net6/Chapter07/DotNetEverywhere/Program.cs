// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;

WriteLine("I can run everywhere!");

WriteLine($"OS Version is {Environment.OSVersion}l");

if(OperatingSystem.IsMacOS())
{
    WriteLine("I am MacOs");

}
else if(OperatingSystem.IsWindowsVersionAtLeast(major:10))
{
    WriteLine("I am Window 10 or 11");

}
else
{
    WriteLine("I am some other mysterious OS.");
}

WriteLine("Press Enter to Stop me.");
ReadLine();
