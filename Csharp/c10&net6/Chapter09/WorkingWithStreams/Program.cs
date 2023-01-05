using static System.Console;
using static System.Environment;
using static System.IO.Path;
using static System.IO.Directory;
using System.Xml;
using System.IO.Compression;



internal class Program
{
    private static void Main(string[] args)
    {
        //WorkWithTest()
        WorkWithXml();
        WorkWithCompression();




        static void WorkWithTest()
        {
            string textFile = Combine(path1: CurrentDirectory, path2: "stream.txt");

            //creat a text file and return a helper writer
            StreamWriter text = File.CreateText(path: textFile);

            //enumerate the strings,writing each one
            //to the stream on a sperate line
            foreach (string item in Viper.Callsigns)
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

            try
            {

                //define a fiel to write to
                string xmlFile = Combine(path1: CurrentDirectory, path2: "streams.xml");

                //create a file stream
                FileStream XmlFileStream = File.Create(path: xmlFile);

                //wrap the file stream in an XML writer helper
                //and automatically indent nested elements
                xml = XmlWriter.Create(output: xmlFileStream,
                settings: new XmlWriterSettings { Indent = true });

                //write the XML declaration
                xml.WriteStartDocument();

                //write a root element 
                xml.WriteStartElement(localName: "callsigns");

                //enumerate the strings writing each one to the stream
                foreach (string item in Viper.Callsigns)
                {
                    xml.WriteElementString(localName: "callsign", value: item);
                }

                //write the close root element
                xml.WriteEndElement();

                //close helper and stream
                xml.Close();
                xmlFileStream.Close();

                //output all the contents of the file
                WriteLine(format: "{0} contains {1:N0} bytes",
                arg0: xmlFile,
                arg1: new FileInfo(fileName: xmlFile).Length);
                WriteLine(value: File.ReadAllText(path: xmlFile));
            }
            catch (Exception ex)
            {
                WriteLine(value: $"{ex.GetType()} says {ex.Message}");
            }
            finally
            {
                if (xml != null)
                {
                    xml.Dispose();
                    WriteLine(value: "The XmL writer's unmanaged resources have been disposed.");
                    if (xmlFileStream != null)
                    {
                        xmlFileStream.Dispose();
                        WriteLine(value: "The file stream's unmanaged resources have been disposed.");

                    }
                }
            }

        }
    

        static void WorkWithCompression(bool useBrotli = true)
        {
            //string fileText = "gzip";
            string fileExt = useBrotli ? "brotli" : "gzip";
            //compress the XML outputs
            string filePath = Combine(
                path1: CurrentDirectory,path2: $"streams.{fileText}"
            );

            FileStream file = File.Create(path: filePath);

            //Stream compressor = new GZipStream(stream: file,mode: CompressionMode.Compress);
            Stream compressor;
            if(useBrotli)
            {
                compressor = new BrotliStream(stream: file, mode: CompressionMode.Compress);
            }
            else
            {
                compressor = new GZipStream(stream:file, mode: CompressionMode.Compress);
            }



            //Compressor
            using(compressor)
            {
                using(XmlWriter xml = XmlWriter.Create(output: compressor))
                {
                    xml.WriteStartDocument();
                    xml.WriteStartElement(localName: "callsigns");

                    foreach(string item in Viper.Callsigns)
                    {
                        xml.WriteElementString(localName: "callsign",value: item);
                    }

                    //the normal call to WriteEndElement is not necessary
                    //because when the XmlWriter disposes, it will
                    //automatically end any elements of any depth
                }
            }  //also clases the underlying stream

            //out all the contents of the compressed file
            WriteLine(format: "{0} contains {1:N0} bytes.",
            arg0: filePath,arg1: new FileInfo(fileName: filePath).Length);

            WriteLine(format:$"The compressed contents;");
            WriteLine(value: File.ReadAllText(path: filePath));
            
            //read a compressed file
            WriteLine(value: "Reading the compressed XML file:");
            file = File.Open(path: filePath, mode: FileMode.Open);

            Stream decompressor;
            if(useBrotli)
            {
                decompressor = new BrotliStream(
                    stream: file,mode: CompressionMode.Decompress);

            }
            else
            {
                decompressor = new GZipStream(
                    stream: file, mode: CompressionMode.Decompress);
                
            }

            //Stream decompressor = new GZipStream(stream: file,
            //mode: CompressionMode.Decompress);

            //Decompressor
            using (decompressor)
            {
                using(XmlReader reader = XmlReader.Create(input: decompressor))
                {
                    while(reader.Read())
                    {
                        //check if we are on an element node named callsign
                        if((reader.NodeType == XmlNodeType.Element)
                        && (reader.Name == "callsign"))
                        {
                            reader.Read();
                            WriteLine(value: $"{reader.Value}");
                        }
                    }
                }
            }
        }
    

    }
}

static class Viper
{
    public static string[] Callsigns = new[]
    {
    "Husker", "Starbuck", "Apollo", "Boomer",
    "Bulldog", "Athena", "Helo", "Racetrack"
    };
}