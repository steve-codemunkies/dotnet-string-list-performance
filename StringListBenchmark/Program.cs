using BenchmarkDotNet.Running;
using StringListBenchmark;

var summary = BenchmarkRunner.Run<AccessBenchmark>();
var summary2 = BenchmarkRunner.Run<CaseSensitiveStringListValidation>();