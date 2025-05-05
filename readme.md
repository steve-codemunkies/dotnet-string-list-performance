# Introduction

This repository explores different methods of determining whether an arbitrary string is valid, based on a pre-existing list. The code looks at case-sensitive and case-insensitive comparisons.

Read the article at [Comparing the performance of string search in dotnet 8](https://www.codemunki.es/2025/05/05/dotnet-string-list-performance/)

## Executing the benchmarks

To execute the benchmarks you first need to build the release version of the code:

```shell
dotnet build ./StringListBenchmark/StringListBenchmark.csproj -c Release -o ./benchmarks
```

Once the release code has been built it can then be executed:

```shell
./benchmarks/StringListBenchmark
```
