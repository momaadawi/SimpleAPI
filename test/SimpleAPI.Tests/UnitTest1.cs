using Xunit;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    [Fact]
    public void GetReturnsCorrectNumber()
    {
        var returnValue = "Les Jackson";
        Assert.Equal("Les Jackson", returnValue);
    }
}