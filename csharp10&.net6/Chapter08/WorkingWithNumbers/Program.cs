// using System;

// namespace WorkingWithNumbers
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }


using System.Numerics; //System.Numerics is a namespace cann't use static
using static System.Console; 


WriteLine("Working with large intergers:");
WriteLine("--------------------------------");

ulong big = ulong.MaxValue;
WriteLine($"{big,40:N0}");

BigInteger bigger =
  BigInteger.Parse("1234567901234567890");

WriteLine($"{bigger,40:N0}");

WriteLine("Working with complex numbers:");
Complex c1 = new(real: 4, imaginary: 2);
Complex c2 = new(real: 3, imaginary: 7);
Complex c3 = c1 + c2;

// output using default ToString implemention
WriteLine($"{c1} added to {c2} is {c3}");

//output using custom format
WriteLine("{0} + {1}i added to {2} + {3} is {4} + {5}i",
c1.Real, c1.Imaginary,
c2.Real, c2.Imaginary,
c3.Real, c3.Imaginary);



