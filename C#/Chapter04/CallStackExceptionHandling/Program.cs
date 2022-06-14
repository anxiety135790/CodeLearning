// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Packt;
using static System.Console;

WriteLine("In Main");
Alpha();
static void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

static void Beta()
{
    WriteLine("In Beta");
    try
    {
        Calcualtor.Gamma();
    }
    catch (Exception ex)
    {
        WriteLine($"Caught this: {ex.Message}");
    }
}



//////////////////////////////////////////////////////////////////////////////////////////
// The call stack is upside-down. Starting from the bottom, you see:                    //
// • The first call is to the Main entry point function in the auto-generated Program   //
// class. This is where arguments are passed in as a string array.                      //
// • The second call is to the Alpha function.                                          //
// • The third call is to the Beta function.                                            //
// • The fourth call is to the Gamma function.                                          //
// • The fifth call is to the Delta function. This function attempts to open a file by  //
// passing a bad file path. This causes an exception to be thrown. Any function         //
// with a try-catch statement could catch this exception. If they do not, it is           //
// automatically passed up the call stack until it reaches the top, where .NET          //
// outputs the exception (and the details of this call stack).                          //
//////////////////////////////////////////////////////////////////////////////////////////
