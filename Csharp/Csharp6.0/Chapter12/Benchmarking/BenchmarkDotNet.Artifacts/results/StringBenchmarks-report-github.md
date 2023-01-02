``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
12th Gen Intel Core i5-1230U, 1 CPU, 12 logical and 10 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT


```
|                  Method |     Mean |    Error |    StdDev | Ratio | RatioSD |
|------------------------ |---------:|---------:|----------:|------:|--------:|
| StringConcatenationTest | 952.2 ns | 67.01 ns | 195.48 ns |  1.00 |    0.00 |
|       StringBuilderTest | 557.9 ns | 32.41 ns |  94.54 ns |  0.61 |    0.16 |
