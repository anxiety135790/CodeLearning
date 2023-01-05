using static System.Console;
using System;
using System.Diagnostics;



internal class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        string city = "London";
        WriteLine($"{city} is {city.Length} characters long.");
        //output:London is 6 characters long.


        WriteLine($"First char is {city[0]} and third is {city[2]}");
        //output:First char is L and third is n.


        string cities = "Paris,Theran,Chennal,Sydney,New York,Mdellin";

        string[] citiesArray = cities.Split(',');

        WriteLine($"There are {citiesArray.Length} items in the array.");
        foreach (string item in citiesArray)
        {
            WriteLine(item);
        }
        /*
        output:
        There are 6 items in the arry.
        Paris
        Tehran
        Chennai
        Sydney
        New York
        Medellin
        */

        string fullName = "Alan Jones";
        int indexOfTheSpace = fullName.IndexOf(' ');

        string firstName = fullName.Substring(
            startIndex: 0, length: indexOfTheSpace);

        string lastName = fullName.Substring(
            startIndex: indexOfTheSpace + 1);

        WriteLine($"Original: {fullName}");
        WriteLine($"Swapped: {lastName}.{firstName}");
        /*
        output:
        Origian: Alan Jones
        Swapped: Jone, Alan
        */


        string company = "Microsoft";
        bool startsWithM = company.StartsWith("M");
        bool containsN = company.Contains("N");
        WriteLine($"Text: {company}");
        WriteLine($"Starts with M: {startsWithM}, contains an N:{containsN}");
        /*
        output:
        Text: Microsoft
        Starts with M: True, contains an N: False
        */

        string recombined = string.Join(" => ", citiesArray);
        WriteLine(recombined);
        // output:Paris => Theran => Chennal => Sydney => New York => Mdellin


        string fruit = "Apples";
        decimal price = 1.39M;
        DateTime when = DateTime.Today;

        WriteLine($"Interpolated: {fruit} cost {price:C} on {when:dddd}.");

        WriteLine(string.Format("string.Format: {1} cost {1:C} on {2:dddd}.",
        arg1: fruit,
        arg2: price,
        arg3: when));
        /*
        Interpolated: Apples cost $0.39 on Monday.
        string.Format: Apples cost $0.39 on Monday.
        */

    }

}


