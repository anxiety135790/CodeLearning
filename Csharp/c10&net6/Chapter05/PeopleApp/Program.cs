// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Packt.Shared;
using static System.Console;


////////////////////////////////////////////////////////////////////////////////////////////
// // var bob = new Person(); // C#1.0 or later                                           //
// Person bob = new(); // C#9.0 or later; class name = new()                              //
// //WriteLine(bob.ToString());                                                           //
//                                                                                        //
// bob.Name = "Bob Smith";                                                                //
// bob.DateOfBirth = new DateTime(1965, 12, 22);                                          //
//                  -                                                                      //
// // WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",                          //
// //           arg0: bob.Name,                                                           //
// //           arg1: bob.DateOfBirth);                                                   //
//                                                                                        //
//                                                                                        //
//                                                                                        //
//                                                                                        //
// Person alice = new()                                                                   //
// {                                                                                      //
//     Name = "Alice Jones",                                                              //
//     DateOfBirth = new(1998, 3, 7)                                                      //
// };                                                                                     //
//                                                                                        //
// // WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",                          //
// //           arg0: alice.Name,                                                         //
// //           arg1: alice.DateOfBirth);                                                 //
//                                                                                        //
//                                                                                        //
//                                                                                        //
//                                                                                        //
//                                                                                        //
// bob.FavoriteAncientWonder =                                                            //
//     WondersOfTheAncientWorld.StatueOfZeusAtOlympia;                                    //
//                                                                                        //
// bob.BucketList =                                                                       //
//     WondersOfTheAncientWorld.HangingGardensOfBabylon                                   //
//     | WondersOfTheAncientWorld.MausoleumAtHalicarnassus; //| bitwise logical OR        //
//                                                                                        //
// // WriteLine(                                                                          //
// //  format: "{0}'s favorite wonder is {1}. Its integer is {2}.",                       //
// //  arg0: bob.Name,                                                                    //
// //  arg1: bob.FavoriteAncientWonder,                                                   //
// //  arg2: (int)bob.FavoriteAncientWonder);                                             //
//                                                                                        //
// //The enum value is internally stored as an int for efficiency.                        //
// //The int values are automatically assigned starting at 0,                             //
// //so the third world wonder in our enum has a value of 2.                              //
// //You can assign  int values that are not listed in the enum.                          //
// //They will output as the int value instead of a name since a match will not be found. //
//                                                                                        //
//                                                                                        //
//                                                                                        //
// WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");                            //
////////////////////////////////////////////////////////////////////////////////////////////



///////////////////////////////////////////////////////////////////////////
//
//bob.Children.Add(new Person { nameof = "Alfred" });//c#3.0 and later    // /
//bob.Children.Add(new() { nameof = "Zoe" });//C# 9.0 and later           // //
//                                                                         // //
// WriteLine(                                                              // //
//     $"{bob.Name} has {bob.Children.Count} children:");                  // //
// for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++) // //
// {                                                                       // //
//  WriteLine($" {bob.Children[childIndex].Name}");                        //
//
// }                                                                       // //
////////////////////////////////////////////////////////////////////////////////


/////////////////////////////////////////////////////////////////////////
//                                                                     //
//BankAccount.InterestRate = 0.012M;                                   //
//                                                                     //
// BankAccount jonesAccount = new();                                   //
// jonesAccount.AccountName = "Mrs.Jones";                             //
// jonesAccount.Balance = 2400;                                        //
//                                                                     //
// WriteLine(format: "{0} earned {1:C} interest.",                     //
//           arg0: jonesAccount.AccountName,                           //
//           arg1: jonesAccount.Balance * BankAccount.InterestRate);   //
//                                                                     //
// BankAccount gerrierAccount = new();                                 //
// gerrierAccount.AccountName = "Mrs. Gerrier";                        //
// gerrierAccount.Balance = 98;                                        //
//                                                                     //
// WriteLine(format: "{0} earned {1:C} interest.",                     //
//           arg0: gerrierAccount.AccountName,                         //
//           arg1: gerrierAccount.Balance * BankAccount.InterestRate); //
/////////////////////////////////////////////////////////////////////////
//



////////////////////////////////////////////////////////////
// Person bob = new();                                    //
// bob.Name = "Bob";                                      //
// WriteLine($"{bob.Name} is a {Person.species}");        //
// WriteLine($"{bob.Name} was born on {bob.HomePlanet}"); //
////////////////////////////////////////////////////////////


/////////////////////////////////////////////////////////////////////
// Person blankPerson = new();                                     //
// WriteLine(format:                                               //
//           "{0} of {1} was created at {2:hh:mm:ss} on a {2:dd}", //
//           arg0: blankPerson.Name,                               //
//           arg1: blankPerson.HomePlanet,                         //
//           arg2: blankPerson.Instantiated);                      //
/////////////////////////////////////////////////////////////////////




///////////////////////////////////////////////////////////////////
// Person gunny = new(initialName: "Gunny", homeplanet: "Mars"); //
// WriteLine(                                                    //
//     "{0} is {1} was creatd at {2:hh:mm:ss} on a {2:dddd}.",   //
//     arg0: gunny.Name,                                         //
//     arg1: gunny.HomePlanet,                                   //
//     arg2: gunny.Instantiated);                                //
///////////////////////////////////////////////////////////////////


////////////////////////////////////////////////////////////////
// Person bob = new(initialName: "Bob", homeplanet: "Earth"); //
// bob.WriteToConsole();                                      //
// WriteLine(bob.GetOrigin());                                //
////////////////////////////////////////////////////////////////




/////////////////////////////////////////////////////////////////////////////////
// Person bob = new(initialName: "Bob", homeplanet: "Earth");                  //
// (string, int) fruit = bob.GetFruit();                                       //
// WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");                      //
//                                                                             //
// var thing1 = ("Neville", 4);                                                //
// WriteLine($"{thing1.Item1} has {thing1.Item2} children.");                  //
// var thing2 = (bob.Name, bob.Children.Count);                                //
// WriteLine($"{thing2.Name} has {thing2.Count} children.");                   //
//                                                                             //
//                                                                             //
// (string Thename, int TheNumber) tupleWithNamedFIElds = bob.GetNamedFruit(); //
//                                                                             //
//                                                                             //
// var (name1, dob1) = bob;                                                    //
// WriteLine($"Deconstructed: {name1}, {dob1}");                               //
/////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////
// Person bob = new(initialName: "Bob", homeplanet: "Earth");    //
// WriteLine(bob.OptionalParameters());                          //
//                                                               //
// int a = 10;                                                   //
// int b = 20;                                                   //
// int c = 30;                                                   //
// WriteLine($"Before: a = {a}, b = {b}, c = {c}");              //
// bob.PassingParameters(a, ref b, out c);                       //
// WriteLine($"After: a = {a}, b = {b}, c = {c}");               //
//                                                               //
// int d = 10;                                                   //
// int e = 20;                                                   //
// WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!"); //
// bob.PassingParameters(d, ref e, out int f);                   //
// WriteLine($"After: d = {d}, e = {e}, f = {f}");               //
///////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////
//
//
//Person sam = new(initialName: "sam", homeplanet: "Earth") //
// {                                                         //
//     Name = "Sam",                                         //
//     DateOfBirth = new(1972, 1, 27)                        //
// };                                                        //
// WriteLine(sam.Origin);                                    //
// WriteLine(sam.Greeting);                                  //
// WriteLine(sam.Age);                                       //
// WriteLine();                                              //
///////////////////////////////////////////////////////////////



///////////////////////////////////////////////////////////////////////////////
// sam.FavoriteIceCream = "Chocolate Fudge";                                 //
// WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}");  //
// sam.FavoritePrimaryColor = "Red";                                         //
// WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}"); //
///////////////////////////////////////////////////////////////////////////////




/////////////////////////////////////////////////////////////////
//     sam.Children.Add(new() {Name = "Charlie"});             //
// same.Children.Add(new() {Name = "Ella"});                   //
// WriteLine($"Sam's first child is {sam.Children[0].Name}");  //
// WriteLine($"Sam's second child is {sam.Children[1].Name}"); //
// WriteLine($"Sam's first child is {sam[0].Name}");           //
// WriteLine($"Sam's second child is {sam[1].Name}");          //
/////////////////////////////////////////////////////////////////




/////////////////////////////////////////////////////////////////////////////
// object[] passengers = {                           //                    //
//     new FirstClassPassenger  { AirMiles == 1_419}, //                    //
//     new FirstClassPassenger { AirMiles = 16_562}, //                    //
//     new BusinessClassPassenger(),                 //                    //
//     new CoachClassPassenger{ CarryOnKG = 25.7},   //                    //
//     new CoachClassPassenger{ CarryOnKG = 0},      //                    //
// };                                                //                    //
//                                                                         //
//                                                                         //
//                                                                         //
//                                                                         //
//                                                                         //
//                                                                         //
// foreach(object passenger in passengers)                                 //
// {                                                                       //
//     decimal flightCost = passenger switch                               //
//         {                                                               //
//                                                                      // //
//             /* C# 8 syntax                                           // //
//             FirstClassPassenger p when p.AirMiles > 35000 => 1500M,  // //
//             FirstClassPassenger p when p.AirMiles > 15000 => 1750M,  // //
//             FirstClassPassenger _                        => 2000M,*/ // //
//                                                                      // //
//                                                                      // //
//             // C# 9 or later syntax                                  // //
//             FirstClassPassenger p => p.AirMiles switch {              // //
//                 > 35000 => 1500M,                                     // //
//                 > 15000 => 1750M,                                     // //
//                 _       => 2000M                                      // //
//             },                                                       // //
//             BusinessClassPassenger _                     => 1000M,    // //
//             CoachClassPassenger p when p.CarryOnKG < 10.0=> 500M,     // //
//             CoachClasPassenger_                          => 650M,     // //
//             _                                            => 800M      // //
//         };                                                           // //
//     WriteLine($"Flight costs {flightCost:C} for {passenger}");       // //
// }                                                                    // //
/////////////////////////////////////////////////////////////////////////////






Immutable jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};



jeff.FirstName = "Geoff";


ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    wheels = 4
};

ImmutableVehicle repainedCar = car
    with { Color = " Polymetal Grey Metallic "};

WriteLine($"Original car color was {car.Color}.");
WriteLien($"New car color is {repaintedCar.Color}.");

ImmutableAnimal oscar = new ("Oscar", "Labrador");
var (who, what)  = oscar;
WriteLine($"{who} is a {what}.");
