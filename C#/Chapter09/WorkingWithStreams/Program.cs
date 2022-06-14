using static System.Console;
using static System.Environment;
using static System.IO.Path;
using static System.IO.Directory;


WorkWithXml();


static class Viper
{
    public static string[] Callsigns = new[]
    {
    "Husker", "Starbuck", "Apollo", "Boomer",
    "Bulldog", "Athena", "Helo", "Racetrack"
    };

    static void WorkWithTet()
    {
        //define a file to write to
        string textFile = Combine(path1: CurrentDirectory,path2: "stream.txt");

        //creat a text file and return a helper writer
        StreamWriter text = File.CreateText(path: textFile);

        //enumerate the strings, writing each one
        //to the stream an a sperate line
        foreach(string item in Viper.Callsigns)
        {
            text.WriteLine(value: item);
        }
        text.Close();

        WriteLine("{0} contains {1:N0} bytes.",
        arg0: textFile,
        arg1: new FileInfo(textFile).Length);

        WriteLine(File.ReadAllText(textFile));
    }

    static void WorkWithXml()
    {
        //define a fiel to write to
        string xmlFile = Combine(CurrentDirectory,"streams.xml");

        //create a file stream
        FileStream xmlFileStream = File.Create(xmlFile);

        //wrap the file stream in an XML writer helper
        //and automatically indent nested elements
        XmlWriter xml = XmlWriter.Create(xmlFileStream,
        new XmlWriterSettings {Indent = true});

        //write the XML declaration
        xml.WriteStartDocument();

        //write a root element 
        xml.WriteStartDocument("callsigns");

        //enumerate the strings writing each one to the stream
        foreach(string item in Viper.Callsigns)
        {
            xml.WriteElementString("callsign",item);
        }

        //write the close root element
        xml.WriteEndElement();

        //close helper and stream
        xml.Close();
        xmlFileStream.Close();

        //output all the contents of the file
        WriteLine("{0} contains {1:N0} bytes",
        arg0:xmlFile,
        arg1:new FileInfo(xmlFile).Length);
        WriteLine(File.ReadAllText(xmlFile));


    }
}