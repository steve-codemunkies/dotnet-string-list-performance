using BenchmarkDotNet.Running;
using StringListBenchmark;

var summary = BenchmarkRunner.Run<AccessBenchmark>();