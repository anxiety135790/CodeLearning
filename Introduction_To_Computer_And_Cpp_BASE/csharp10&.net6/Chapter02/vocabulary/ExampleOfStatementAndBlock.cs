// See https://aka.ms/new-console-template for more information
using System; // a semicolon indicates the end of a statement
using System.Reflection;
    // System.Data ds;
    // HttpClient client;


//  namespace Basics
// { // an open brace indicates the start of a block
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Console.WriteLine("Hello World!"); // a statement
//             Assembly? assembly = Assembly.GetEntryAssembly();
//             if (assembly == null) return;

//             //loop through the assemblies that is app references
//             foreach(AssemblyName name in assembly.GetReferencedAssemblies())
//             {
//                 // load the assambly so we can read its details
//                 Assembly a = Assembly.Load(name);

//                 int methodCount = 0;
//                 foreach(TypeInfo t in a.DefinedTypes)
//                 {
//                     methodCount += t.GetMethods().Count();
//                 }

//                 Console.WriteLine(
//                     "{0:N0} types with (1:N0) methods in {2} assembly.",
//                     arg0: a.DefinedTypes.Count(),
//                     arg1: methodCount,arg2: name.Name
//                 );
//             }
//         }
//     } */
// } // a close brace indicates the end of a block


//three variables that store the number 2 million
// int decimalNotation = 2_000_000;
// int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
// int hexadecimalNotation = 0x_001E_8480;

// Console.WriteLine($"{decimalNotation == binaryNotation}");
// Console.WriteLine(
//     $"{decimalNotation == hexadecimalNotation}");


Console.WriteLine(
    $"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine(
    $"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine(
    $"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
