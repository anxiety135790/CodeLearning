// See https://aka.ms/new-console-template for more information

//WriteLine("Hello, World!");
using static System.Console;

// int a = 3;
// int b = a++;


// Console.WriteLine($"a is {a}, b is {b}");

// int c = 3;
// int d = ++c;
// Console.WriteLine($"c is {c}, d is {d}");

int e = 11;
int f = 3;

WriteLine($"e is {e},f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");


double g = 11;
WriteLine($"g is {g:N2}, f is {f}"); //N1:11.0;N2:11.00
WriteLine($"g / f = { g / f}");


int p = 6;

p += 3;
WriteLine(p);

p -= 3;
WriteLine(p);

p *= 3;
WriteLine(p);

p /= 3;
WriteLine(p);

// bool a = true;
// bool b = false;

// Console.WriteLine($"And | a | b   ");
// Console.WriteLine($"a   |{a & a,-5} | {a & b,-5}");
// Console.WriteLine($"b   |{b & a,-5} | {b & b,-5}");
// Console.WriteLine();
// Console.WriteLine($"OR  | a | b   ");
// Console.WriteLine($"a   | {a | a,-5} | {a | b,-5}");
// Console.WriteLine($"b   | {b | b,-5} | {b | b,-5}");
// Console.WriteLine();
// Console.WriteLine($"XOR | a | b   ");
// Console.WriteLine($"a   | {a ^ a,-5} | {a ^ b,-5}");
// Console.WriteLine($"b   | {b ^ a,-5} | {b ^ b,-5}");


static bool DoStuff()
{
    WriteLine("I am doing some stuff");
    return true;
}

// //Output str & the Judgement of the AND between aplhat and  DoStuff
// WriteLine($"a & DoStuff() = {a & DoStuff()}");
// Console.WriteLine($"b & DoStuff() = {b & DoStuff()}");

// // && will stop the function when the first judgement was false
// Console.WriteLine($"a & DoStuff() = {a && DoStuff()}");
// Console.WriteLine($"b & DoStuff() = { b && DoStuff()}");











