namespace RefactoredToCleanCodeTests;
using RefactoredToCleanCodeProduction;

public class RefactoredToCleanCodeTests
{
    private GuessStatisticsMessage _gl;
    private void TestSetUp()
    {
        _gl = new GuessStatisticsMessage();
    }
    
    [Fact]
    public void ShouldReturnThereAreNoAsGivenCountCeroAnd_A()
    {
        TestSetUp();
        string result = _gl.Make('A', 0);
        Assert.Equal("There are no As", result);
    }
    
    [Fact]
    public void ShouldReturnThereIsOnAsGivenCountOfOneAnd_A()
    {
        TestSetUp();
        string result = _gl.Make('A', 1);
        Assert.Equal("There is 1 A", result);
    }
    
    [Fact]
    public void ShouldReturnThereAreFiveCsGivenCountOfFiveAnd_C()
    {
        TestSetUp();
        string result = _gl.Make('C', 5);
        Assert.Equal("There are 5 Cs", result);
    }
    

}