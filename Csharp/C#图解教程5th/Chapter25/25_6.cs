#define DoTrace
using System;
using System.Diagnostics;

namespace AttributesConditional
{
    class Program

    {
        [Conditional("DoTrace")]
        static void TraceMessages(string str)
        {
            Console.WriteLine(str);
        }

        static void Main()
        {
            TraceMessages("Start of Main");
            Console.WriteLine("Doing work in Main.");
            TraceMessages("End of Main");
        }
    }
}
