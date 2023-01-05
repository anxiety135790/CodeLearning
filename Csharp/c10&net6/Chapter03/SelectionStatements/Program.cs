// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello World!");
using static System.Console;


/* string password = "ninja";
if (password.Length < 8)
    WriteLine("Your password is too short. Use at least 8 characters.");
else
    WriteLine("Your password is strong.");

object o = "3";
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}

int number = (new Random()).Next(1, 7);
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        WriteLine("Three or Four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("default");
        break;
}
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label"); */



// string path = ..\Project\
string path = @"C:\Users\Barxhe1209\Documents\csharp10&.net6\Chapter03\SelectionStatements\";

WriteLine("Press R for read-only or W for writeable: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream? s;

if (key.Key == ConsoleKey.R)
{
    
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read);

}
else
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write);
}




/* //switch case template
string message;

switch (s)
{
    case FileStream writeableFile when s.CanWrite:
        {
            message = "The stream is a file tha I can write to.";
            break;
        }

    case FileStream readOnlyFile:
        {
            message = "The stream is a read-only file.";
            break;
        }
    case MemoryStream ms:
        {
            message = "The stream is a memory address.";
            break;
        }
    default:
        message = "The stream is some other type.";
        break;
    case null:
        {
            message = "The stream is null.";
            break;
        }

}

WriteLine(message); */


/* // remove the case and break keywords.
message = s switch
{
    FileStream writeableFile when s.CanWrite
    => "The stream is a file tha I can write to.",
    FileStream readOnlyFile
    => "The stream is a read-only file.",
    MemoryStream ms
    => "The stream is a memory address.",
    null
    => "The stream is null",
    _ //_ is used to represent the default return value.
    => "The stream is some other type."
};
WriteLine(message); */


/* //while loop
int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
} */



//do...while loop while->do
/* string? password02;

do
{
    Write("Enter your password02: ");
    password02 = ReadLine();

} while (password02 != "Pa$$w0rd");

WriteLine("Correct!");
 */


//Loop with the for statement
for (int y = 1; y < 10; ++y)
{
    WriteLine(y);
}


//loop with the foreach statement
string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}


/* //how foreach works internally
IEnumerator e = names.GetEnumerator();

while(e.MoveNext)
{
    string name = (string)e.Current;
    WriteLine($"{name} has {name.Length} characters.");
}
 */


//casting and convert between types
