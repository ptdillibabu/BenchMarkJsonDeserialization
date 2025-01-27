```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i7-10610U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 5.0.416
  [Host]     : .NET Core 3.1.32 (CoreCLR 4.700.22.55902, CoreFX 4.700.22.56512), X64 RyuJIT AVX2
  DefaultJob : .NET Core 3.1.32 (CoreCLR 4.700.22.55902, CoreFX 4.700.22.56512), X64 RyuJIT AVX2


```
| Method                         | Mean       | Error    | StdDev   |
|------------------------------- |-----------:|---------:|---------:|
| DeserializeUsingNewtonsoftJson | 1,227.4 ns | 24.26 ns | 23.83 ns |
| DeserializeUsingSystemTextJson |   592.8 ns | 10.01 ns | 12.65 ns |
