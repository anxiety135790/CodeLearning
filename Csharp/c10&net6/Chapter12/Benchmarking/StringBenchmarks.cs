//namespace Benchmarking;

using BenchmarkDotNet.Attributes;

public class StringBenchmarks
{
    int[] numbers;
    public StringBenchmarks()
    {
        numbers = Enumerable.Range(
            start: 1, count: 1).ToArray();
    }

    [Benchmark(Baseline = true)]
    public string StringConcatenationTest()
    {
        string s = string.Empty;
        for (int i = 0; i < numbers.Length; i++)
        {
            s += numbers[i] + ", ";
        }
        return s;
    }

    [Benchmark]
    public string StringBuilderTest()
    {
        System.Text.StringBuilder builder = new();
        for (int i = 0; i < numbers.Length; i++)
        {
            builder.Append(numbers[i]);
            builder.Append(", ");
        }
        return builder.ToString();
    }

}
