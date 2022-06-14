using static System.Console;
using static System.Environment;
using static System.IO.Path;
using static System.IO.Directory;



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
}