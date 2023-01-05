``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
12th Gen Intel Core i5-1230U, 1 CPU, 12 logical and 10 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT


```
|                  Method |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |
|------------------------ |---------:|---------:|---------:|---------:|------:|--------:|
| StringConcatenationTest | 17.01 ns | 0.403 ns | 1.181 ns | 16.78 ns |  1.00 |    0.00 |
|       StringBuilderTest | 24.29 ns | 0.575 ns | 1.687 ns | 23.79 ns |  1.43 |    0.14 |
