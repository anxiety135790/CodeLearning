// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;


namespace Packt.Shared
{

    public class Person
    {
        /*The constructor does not need to do anything, 
        but it must exist so that the XmlSerializer 
        can call it to instantiate new Person instances
         during the deserialization process*/
        public Person()
        {
        }

        public Person(decimal initialiSalary)
        {
            Salary = initialiSalary;
        }


        [XmlAttribute(attributeName: "fname")]
        public string? FirstName { get; set; }

        [XmlAttribute(attributeName: "lname")]
        public string? LastName { get; set; }

        [XmlAttribute(attributeName: "dob")]
        public DateTime DateOfBirth { get; set; }
        public HashSet<Person>? Children { get; set; }
        protected decimal Salary { get; set; }
    }
}
