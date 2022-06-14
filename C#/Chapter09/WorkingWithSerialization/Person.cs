// See https://aka.ms/new-console-template for more information

namespace Packt.Shared;

public class Person
{
    public Person(decimal initialiSalary)
    {
        Salary = initialiSalary;
    }

    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public DateTime DateOfBirth {get; set;}
    public HashSet<Person>? Children {get; set;}
    protected decimal Salary {get; set;}
}

public Person(){ }