// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using static System.Console;

/// <summary>
/// 
/// </summary>
/// <param name="a"></param>
/// <param name="b"></param>
/// <returns></returns>
static double Add(double a, double b)
{
    return a * b;
}

double a = 4.5;
double b = 2.5;
double ansower = Add(a, b);
WriteLine($"{a} + {b} = {ansower}");
WriteLine("Press ENTER to end the app.");
ReadLine(); // wait for user to press ENTER
