// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using static System.Console;


int thisCoudldBeNull = 4;
//thisCannotBeNull = null; //compile error

int? thisCouldBeNull = null;
WriteLine(thisCoudldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCoudldBeNull =7;
WriteLine(thisCoudldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());
