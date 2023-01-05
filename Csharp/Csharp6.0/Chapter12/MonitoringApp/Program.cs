using Packt.Shared;

using static System.Console;

/*WriteLine("Processing. Please wait...");
Recorder.Start();

//simulate a prcess that requires some memoy resources ...
int[] largeArrahyOfInts = Enumerable.Range(
    start: 1, count: 10_000).ToArray();

//... and taks some time to complete
 Thread.Sleep(new Random().Next(5,10) * 1000);

 Recorder.Stop();*/

int[] numbers = Enumerable.Range(
    start: 1, count: 50_000).ToArray();

WriteLine("");
Recorder.Start();

string s = string.Empty;
System.Text.StringBuilder builder = new();



for( int i = 0; i < numbers.Length; i++)
{
    builder.Append(numbers[i]);
    builder.Append(", ");

}
Recorder.Stop();
