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

        WriteLine(format: "{0} contains {1:N0} bytes.",
        arg0: textFile,
        arg1: new FileInfo(fileName: textFile).Length);

        WriteLine(value: File.ReadAllText(path: textFile));
    }

    static void WorkWithXml()
    {
        FileStream? xmlFileStream = null;
        XmlWriter? xml = null;

        try{

        //define a fiel to write to
        string xmlFile = Combine(path1: CurrentDirectory,path2: "streams.xml");

        //create a file stream
        xmlFileStream = File.Create(path: xmlFile);

        //wrap the file stream in an XML writer helper
        //and automatically indent nested elements
        xml = XmlWriter.Create(xmlFileStream,
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
        WriteLine(format: "{0} contains {1:N0} bytes",
        arg0:xmlFile,
        arg1:new FileInfo(fileName: xmlFile).Length);
        WriteLine(value: File.ReadAllText(path: xmlFile));
        }
        catch(Exception ex)
        {
            WriteLine(value: $"{ex.GetType()} says {ex.Message}");
        }
        finally
        {
            if(xml != null)
            {
                xml.Dispose();
                WriteLine(value: "The xml writer's unmanaged resources have been disposed.");
                if(xmlFileStream != null)
                {
                    xmlFileStream.Dispose();
                    WriteLine(value: "The file stream's unmanaged resources have been disposed.");
                }
            }
        }

    }
}