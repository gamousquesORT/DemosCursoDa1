using ConsoleApp1;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace RefactorCleanCodeTests;

public class RefactorCleanCodeTests
{
    private GuessLetters _gl;
    public void TestSetUp()
    {
        _gl = new GuessLetters();
    }
    
    [Fact]
    public void ShouldReturnThereAreNoAsGivenCountCeroAnd_A()
    {
        TestSetUp();
        string result = _gl.GetGuessStatistics('A', 0);
        Assert.Equal("There are no As", result);
    }
    
    [Fact]
    public void ShouldReturnThereIsOnAsGivenCountOfOneAnd_A()
    {
        TestSetUp();
        string result = _gl.GetGuessStatistics('A', 1);
        Assert.Equal("There is 1 A", result);
    }
    
    [Fact]
    public void ShouldReturnThereAreFiveCsGivenCountOfFiveAnd_C()
    {
        TestSetUp();
        string result = _gl.GetGuessStatistics('C', 5);
        Assert.Equal("There are 5 Cs", result);
    }
    
    [Fact]
    public void ShouldReturnExceptionGivenNegativeCountAnd_A()
    {
        TestSetUp();
        Assert.Throws<ArgumentException>(() => _gl.GetGuessStatistics('A', -5));
    }
    
}