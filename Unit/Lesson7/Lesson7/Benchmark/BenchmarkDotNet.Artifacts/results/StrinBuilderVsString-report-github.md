```

BenchmarkDotNet v0.13.11, Windows 10 (10.0.19045.3803/22H2/2022Update)
Intel Core i7-10700 CPU 2.90GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method            | Mean         | Error       | StdDev      |
|------------------ |-------------:|------------:|------------:|
| StringTest        | 635,988.7 μs | 3,381.17 μs | 2,997.32 μs |
| StringBuilderTest |     105.8 μs |     0.47 μs |     0.41 μs |
