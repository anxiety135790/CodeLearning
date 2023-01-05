// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;


//warp error-prone code in a try block

WriteLine("Before parsing"); 
Write("What is your age? "); 
string? input = ReadLine();

try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old.");

}
/* catch(Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
} */
catch (OverflowException)
{
 WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (FormatException)
{
 WriteLine("The age you entered is not a valid number format."); //tips:9876543210
}
WriteLine("After parsing");




//catching with filters
Write("Enter an amount: ");
string? amount = ReadLine();
try
{
    decimal amountValue = -decimal.Parse(amount);
}
catch(FormatException) when (amount.Contains("$"))
{
   WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
 WriteLine("Amounts must only contain digits!");
}