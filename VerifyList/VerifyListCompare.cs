namespace VerifyList;

public class VerifyListCompare
{
    private static readonly List<string> _defaultList = ["ABC123"];

    [Theory]
    [InlineData("ABC123", true)]
    [InlineData("abc123", false)]
    public void VerifyDefaultList_ContainsNoComparer(string input, bool expected)
    {
        Assert.Equal(_defaultList.Contains(input), expected);
    }

    [Theory]
    [InlineData("ABC123", true)]
    [InlineData("abc123", true)]
    public void VerifyDefaultList_ContainsComparer(string input, bool expected)
    {
        Assert.Equal(_defaultList.Contains(input, StringComparer.InvariantCultureIgnoreCase), expected);
    }
}
