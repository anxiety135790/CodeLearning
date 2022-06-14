// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
 
using System.Xml.Serialization;
using Packt.Shared;

using static System.Console;
using static System.Environment;
using static System.IO.Path;


List<Person> people = new List<Person>()
{
    new(30000M)
    {
        FristName = "Alice",
        LastName = "Smith",
        DateOfBirth = new(1974,03,14)
    },
    new(40000M)
    {
        FirstName="",
        LastName="",
        DateOfBirth = new()
    },
    new(20000M)
    {
        FirstName="",
        LastName="",
        DateOfBirth = new(1984,05,04),
        Children = new()
        {
            new(0M)
            {
                FirstName = "Sally",
                LastName = "Cox",
                DateOfBirth = new(2000,07,12)
            }
        }
    }

};

XmlSerializer xs = new XmlSerializer(people.GetType());

//create a file to write to
string path = Combine(path1:CurrentDirectory, path2:"people.xml");

using(FileStream stream = File.Create(path))
{
    xs.Serialize(stream, people);

}

WriteLine(format:"Writen {0:N0} bytes of XML to {1}",
          arg0: new FileInfo(path).Length,
          arg1: path);
WriteLine();

//Display the serialized object graph
WriteLine(value:File.ReadAllText(path));
