// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Packt.Shared;
using static System.Console;

Person harry = new() {Name = "Harry"};
Person marry = new() {Name = "Mary"};
Person jill = new() {Name = "Jill"};

// call instance method
Person baby1 = mary.ProcreatWith(harry);
baby1.Name = "Gary";

//call static method
Person baby2 = Person.Procreate(harry,jill);

WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{marry.Name} has {marry.Children.Count} children.");
WriteLine(
    format:"{0}'s first child is named \"{1}\".",
    arg0: harry.Name,
    arg1: harry.Children[0].Name);

//call static method
Person baby2 = Person.Procreate(harry, jill);

//call on operatorq
Person baby3 = harry*mary;



////////////////////////////////////////////////
//
// WriteLine($"5! is {Person.Factorial(5)}"); //
////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// int answer = p1.MethodIWantToCall("Frog");                                                                               //
// delegate int DelegateWithMatchingSignature(string s);                                                                    //
//                                                                                                                          //
// static void Harry_Shout(objdect? sender, EventArgs e) // Microsoft's convention for method names is ObjectName_EventName //
// {                                                                                                                        //
//     if(sender is null) return;                                                                                           //
//     Person p = (Person)sender;                                                                                           //
//     WriteLien($"{p.Name} is this angry: {p.AngerLevel}.");                                                               //
// }                                                                                                                        //
//                                                                                                                          //
// harry.Shout = Marry_Shout;                                                                                               //
// harry.Poke();                                                                                                            //
//                                                                                                                          //
//                                                                                                                          //
// System.Collections.Hashtable lookupObject = new();                                                                       //
//                                                                                                                          //
// lookupObject.Add(key: 1, value:"alpha");                                                                                 //
// lookupObject.Add(key: 2, value: "Beta");                                                                                 //
// lookupObject.Add(key: 3, value: "Gamma");                                                                                //
// lookupObject.Add(key: harry, value: "Delate");                                                                           //
// int key = 2;                                                                                                             //
// WriteLine(format: "key {0} has value : {1}",                                                                             //
//           arg0: key,                                                                                                     //
//           arg1: lookupObject[key]);                                                                                      //
//                                                                                                                          //
//                                                                                                                          //
// Dictionary<int, string> lookupIntString = new();                                                                         //
// lookupIntString.Add(key: 1, value: "Alpha");                                                                             //
// lookupIntString.Add(key: 2, value: "Beta");                                                                              //
// lookupIntString.Add(key: 3, value: "Gamma");                                                                             //
// lookupIntString.Add(key: 4, value: "Delta");                                                                             //
//                                                                                                                          //
// int key =4;                                                                                                              //
// WriteLine(format: "Key {0} has value : {1}",                                                                             //
//           arg0: key,                                                                                                     //
//           arg1: lookupIntString[key]);                                                                                   //
//                                                                                                                          //
//                                                                                                                          //
// Person[] people =                                                                                                        //
// {                                                                                                                        //
//     new() {Name = "Simon"},                                                                                              //
//     new() {Name = "Jenny"},                                                                                              //
//     new() {Name = "Adam"},                                                                                               //
//     new() {Name = "Richard"}                                                                                             //
// };                                                                                                                       //
//                                                                                                                          //
// WriteLine("Initial list of people:");                                                                                    //
// foreach (Person p in people)                                                                                             //
// {                                                                                                                        //
//     WriteLine($"{p.Name}");                                                                                              //
// }                                                                                                                        //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////////////
// WriteLine("Use PersonComparer's IComparer implementation to sort:"); //
// Array.Sort(people , new PersonComparer());                           //
// foreach (Person p in people)                                         //
// {                                                                    //
//     WriteLine($"{p.Name}");                                          //
// }                                                                    //
//////////////////////////////////////////////////////////////////////////

DisplacementVector dv1 = new(3,5);
DisplacementVector dv2 = new(-2,7);
DisplacementVector dv3 = dv1 + dv2;
WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2,X}, {dv2.Y}) = ({dv3.X},{dv3.Y}) ");

