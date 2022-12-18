// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;

int a = 10; // 00001010
int b = 6;  // 00000110

WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}");  //00000010 2
WriteLine($"a | b = {a | b}");  //00001110 14
WriteLine($"a ^ b = {a ^ b}");  //00001100 12

WriteLine($"a << 3 = {a << 3}");   //00001010 -> 01010000
WriteLine($"a * 8 = {a * 8}");     //10*8
WriteLine($"b >> 1 = { b >> 1 }"); //00000011

static string ToBinaryString(int value)
{
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}

WriteLine();
WriteLine("Outputting integers as binary");
WriteLine($"a = {ToBinaryString(a)}");
WriteLine($"b = {ToBinaryString(b)}");
WriteLine($"a & b = {ToBinaryString(a & b)}");
WriteLine($"a | b = {ToBinaryString(a | b)}");
WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");

int age = 47;

//How many operators in the following statement?
char firstDigit = age.ToString()[0];

// There are four operators:
// = is the assignment operator
// . is the member access operator
// () is the invocation operator
// [] is the indexer access operator