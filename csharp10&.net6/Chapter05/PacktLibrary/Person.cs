using System;
using static System.Console;
using System.Collections.Generic;


namespace Packt.Shared
{
    public partial class Person : System.Object
    {
        public string Name;
        public DateTime DateOfBirth;

        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>(); //use .NET Standard 2.0
        //public List<Person> Children = new(); //C#7.0 or later

        public const string species = "Home Sapien";

        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;


        //Person Constructors
        //Fields oftrn need to be initlized at runtime.
        //You do this in a construct will be called when you make
        //an instance of the class using the new keyboard
        //Constructors execute before any fields are set by the code
        //which is using the type.
        public Person(string initialName, string homeplanet)
        {
            // set default values  for fields
            // including read-only fields
            Name = initialName;
            HomePlanet = homeplanet;
            Instantiated = DateTime.Now;

        }


        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");

        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit()
        {
            return ("Apple", 5);
        }

        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true)
        {
            return string.Format(
                format: "command is {0}, number is {1}, active is {2}",
                arg0: command,
                arg1: number,
                arg2: active);
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out paramenters cannot have a default
            // AMD must be initialized indise the method
            z = 99;
            x++;
            y++;
            z++;

        }


        public TextAndNumber GetTheData()                                           //
        {                                                                           //
            return new TextAndNumber                                                //
            {                                                                       //
                Text = "What's the meaning of life?",                               //
                Number = 42                                                         //
            };                                                                      //
        }
        public void Deconstruct(out string name, out DateTime dob)                  //
        {                                                                           //
            name = Name;                                                            //
            dob = DateOfBirth;                                                      //
        }


        public void Deconstruct(out string name,                                    //
                                out DateTime dob,
                                out WondersOfTheAncientWorld fav) //
        {                                                                           //
            name = Name;                                                            //
            dob = DateOfBirth;                                                      //
            fav = FavoriteAncientWonder;                                            //
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHelloTo(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }
    }



    public class TextAndNumber
    {
        public string Text;
        public int Number;
    }

    public class LifeTheUniverseAndEverything
    {
        public TextAndNumber GetTheData()
        {
            return new TextAndNumber
            {
                Text = "What's the meaning of life?",
                Number = 42
            };
        }
    }


}







