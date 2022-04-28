using System;
using System.Collections.Generic;


public static void Main();
{
    List<string> fruits = new List<string>();
    fruits.Add("Apple");
    fruits.Add("Banana");
    fruits.Add("Carrot");


    Console.WriteLine("Count:{0}", fruits.Count);
    PrintValue1(fruits);
    PrintValue2(fruits);
    PrintValue3(fruits);
}

static void PrintValue1(List<string> myList)
{
    for (int i = 0, i< myList.Count; i++)
        Console.Write("{0}\n", myList[i]);
}

static void PrintValue2(List<string> myList)
{
    foreach (string item in myList)
        Console.Write("{0}\n", item);

    static void PrintValue3(List<string> myList)
    {
        IEnumerator<string> myEnumentor = myList.GetEnumerator();
        while (myEnumentor.MoveNext())
            Console.Write("{0}\n", myEnumentor.Current);

    }
}