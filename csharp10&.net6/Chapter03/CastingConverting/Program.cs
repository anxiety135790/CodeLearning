// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;
using static System.Convert;

int a = 10;
double b = a;
WriteLine(a);


//potentially unsaafe and could lose data to convert double into int.
double c = 9.8;
//int d = c;
WriteLine(c);
int d = (int)c;
WriteLine(d);


long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}");
WriteLine($"g is {g} and h is {ToInt32(g)}");


//Roounding number


//type[] var = {...};
double[] doubles = new[] {9.49, 9.5, 9.51, 10.49, 10.5, 10.51};
foreach(double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}


//control round rules
//digits: number of the fractionial digits
foreach(double n in doubles)
{
    WriteLine(format:
    "Matrh.Round({0},0,MidpointRounding.AwayFromZero is {1})",
    arg0: n,
    arg1: Math.Round(value: n, digits: 0,
    mode: MidpointRounding.AwayFromZero));
    
}

int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
//Now is a Non-invocable member
DateTime  now = DateTime.Now;
WriteLine(now.ToString());

//new a object which can hierachy 
//new need a (),[],{}
object me = new();
WriteLine(me.ToString());





//allocate array of 128 bytes
byte[] binaryObject = new byte[128];

//populate array with random bytes
(new Random()).NextBytes(binaryObject);
WriteLine("Binary Object as bytes:");

for(int index = 0; index < binaryObject.Length; index ++)
{
    Write($"{binaryObject[index]:X}");  //X:format the value using hexadecimail notation.
}
WriteLine();
WriteLine();
//conver to Base64 string and output as text
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64:{encoded}");



//Parse the datetime value
int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");

WriteLine($"I was born {age} years ago."); 
WriteLine($"My birthday is {birthday}."); 
WriteLine($"My birthday is {birthday:D}.");  // D:format code to output only the date part using the long date format.

////errors using parse
//int count = int.Parse("abs");


//TryParse to avoid errors

Write("How many eggs are there? "); 
string? input = ReadLine(); // or use "12" in notebook

//bool int TryParse(string?, out int result)
if(int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}else{
    WriteLine("I coudle not parse the input.");
}