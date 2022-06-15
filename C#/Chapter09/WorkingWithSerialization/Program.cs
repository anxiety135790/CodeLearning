// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using System.Xml.Serialization;
using Packt.Shared;

using static System.Console;
using static System.Environment;
using static System.IO.Path;


List<Person> people = new List<Person>()
{
    new Person(initialiSalary: 30000M)
    {
        FirstName = "Alice",
        LastName = "Smith",
        DateOfBirth = new DateTime(year: 1974,month: 03,day: 14)
    },
    new Person(initialiSalary: 40000M)
    {
        FirstName="",
        LastName="",
        DateOfBirth = new DateTime()
    },
    new Person(initialiSalary: 20000M)
    {
        FirstName="",
        LastName="",
        DateOfBirth = new DateTime(year: 1984,month: 05,day: 04),
        Children = new HashSet<Person>()
        {
            new Person(initialiSalary: 0M)
            {
                FirstName = "Sally",
                LastName = "Cox",
                DateOfBirth = new DateTime(year: 2000,month: 07,day: 12)
            }
        }
    }

};

XmlSerializer xs = new XmlSerializer(type: people.GetType());

//create a file to write to
string path = Combine(path1: CurrentDirectory, path2: "people.xml");

using (FileStream stream = File.Create(path: path))

{
    xs.Serialize(stream: stream, o: people);

}

WriteLine(format: "Writen {0:N0} bytes of XML to {1}",
          arg0: new FileInfo(fileName: path).Length,
          arg1: path);
WriteLine();

//Display the serialized object graph
WriteLine(value: File.ReadAllText(path: path));

using (FileStream xmlLoad = File.Open(path: path, mode: FileMode.Open)) 
{
    List<Person>? loadedPeople =
    xs.Deserialize(stream: xmlLoad) as List<Person>;

    if (loadedPeople is not null)
    {
        foreach (Person p in loadedPeople)
        {
            WriteLine(format: "{0} has {1} children.",
            arg0: p.LastName, arg1: p.Children?.Count ?? 0);
        }
    }
}


string jsonPath = Combine(path1: CurrentDirectory, path2: "people.json");

using(StreamWriter jsonStream = File.CreateText(path: jsonPath))
{
    Newtonsoft.Json.JsonSerializer  jss = new();

    jss.Serialize(textWriter: jsonStream, value: people);
}
WriteLine();

WriteLine(format: "Written {0:N0} bytes of JSON to: {1}",
arg0: new FileInfo(fileName: jsonPath).Length,
arg1:jsonPath);

//Display the serialized object graph
WriteLine(value: File.ReadAllText(path: jsonPath));