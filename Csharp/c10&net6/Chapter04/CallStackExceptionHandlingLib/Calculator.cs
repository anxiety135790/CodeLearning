using static System.Console;

namespace Packt;

public class Calcualtor
{
    public static void Gamma()
    {
        WriteLine("In Gamma");
        Delta();
    }
    private static void Delta()
    {
        WriteLine("In Delta");
        File.OpenText("bad file path");

    }


}




