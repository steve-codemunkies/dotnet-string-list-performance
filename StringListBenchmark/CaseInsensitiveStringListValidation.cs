using BenchmarkDotNet.Attributes;

namespace StringListBenchmark;

[MemoryDiagnoser, RPlotExporter]
public class CaseInsensitiveStringListValidation
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
    private static readonly string[] _testArray = [
        "AB12",
        "gh56ij",
        "MN90OP12",
        "st34uv56",
        "YZ78AB90CD",
        "eF12gH34",
        "kl56mn78Op",
        "qR90sT12uV",
        "wX34yZ56aB",
        "cd78ef90",
        "1A2B3C4D",
        "6f7g8h9i0",
        "1K2l3M4n5",
        "6P7q8R9s0T",
        "1u2V3w4X5y",
        "6Z7A8B9C0D",
        "1E2f3G4h5I",
        "6J7k8L9m0N",
        "1O2p3Q4r5S",
        "6T7u8V9w0X"
    ];
    private Random _random = new();

    [Benchmark(Baseline = true)]
    public bool ListContains() => _codesList.Contains(_testArray[_random.Next(0, _testArray.Length)], StringComparer.InvariantCultureIgnoreCase);

    [Benchmark]
    public bool SwitchContains()
    {
        var testValue = _testArray[_random.Next(0, _testArray.Length)];
        return testValue.ToLowerInvariant() switch
        {
            "ab12" => true,
            "gh56ij" => true,
            "mn90op12" => true,
            "st34uv56" => true,
            "yz78ab90cd" => true,
            "ef12gh34" => true,
            "kl56mn78op" => true,
            "qr90st12uv" => true,
            "wx34yz56ab" => true,
            "cd78ef90" => true,
            _ => false
        };
    }
}
