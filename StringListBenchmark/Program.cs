using BenchmarkDotNet.Running;
using StringListBenchmark;

var summary = BenchmarkRunner.Run<AccessBenchmark>();
var summary2 = BenchmarkRunner.Run<CaseSensitiveStringListValidation>();
var summary3 = BenchmarkRunner.Run<CaseInsensitiveStringListValidation>();