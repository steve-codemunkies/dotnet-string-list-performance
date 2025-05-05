using BenchmarkDotNet.Attributes;

namespace StringListBenchmark;

[MemoryDiagnoser, RPlotExporter]
public class CaseSensitiveStringListValidation
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
        "Cd78Ef90"
    ];
    private static readonly List<string> _codesList = new(_codesArray);
    private static readonly string[] _testArray = [.. _codesArray,
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
    private Random _random = new();

    [Benchmark(Baseline = true)]
    public bool ListContains() => _codesList.Contains(_testArray[_random.Next(0, _testArray.Length)]);

    [Benchmark]
    public bool SwitchContains()
    {
        var testValue = _testArray[_random.Next(0, _testArray.Length)];
        return testValue switch
        {
            "Ab12" => true,
            "Gh56Ij" => true,
            "Mn90Op12" => true,
            "St34Uv56" => true,
            "Yz78Ab90Cd" => true,
            "Ef12Gh34" => true,
            "Kl56Mn78Op" => true,
            "Qr90St12Uv" => true,
            "Wx34Yz56Ab" => true,
            "Cd78Ef90" => true,
            _ => false
        };
    }
}
