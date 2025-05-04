using BenchmarkDotNet.Attributes;

namespace StringListBenchmark;

[MemoryDiagnoser, RPlotExporter]
public class AccessBenchmark
{
    private static readonly string[] _codesArray = [
        "Ab12",
        "Gh56Ij",
        "Mn90Op12",
        "St34Uv56",
        "Yz78Ab90Cd",
        "Ef12Gh34",
        "Kl56Mn78Op",
        "Qr90St12Uv",
        "Wx34Yz56Ab",
        "Cd78Ef90",
        "1a2B3c4D",
        "6F7g8H9i0",
        "1k2L3m4N5",
        "6P7q8R9s0T",
        "1u2V3w4X5y",
        "6Z7a8b9c0d",
        "1E2f3G4h5I",
        "6J7k8L9m0N",
        "1O2p3Q4r5S",
        "6T7u8V9w0X"
    ];
    private static readonly List<string> _codesList = new(_codesArray);
    private Random _random = new();

    [Benchmark(Baseline = true)]
    public string ListAccess() => _codesList[_random.Next(0, _codesList.Count)];

    [Benchmark]
    public string ArrayAccess() => _codesArray[_random.Next(0, _codesArray.Length)];
}
