namespace RefactoredToCleanCodeProduction;
public class GuessStatisticsMessage
{      
    private string? _number;
    private string? _verb;
    private string? _pluralModifier;
    
    public string Make(char candidate, int count)
    {
        this.CreatePluralDependentMessageParts(count);
        return $"There {_verb} {_number} {candidate}{_pluralModifier}";
    }
    
    public void CreatePluralDependentMessageParts(int count)
    {
        if (count == 0)
        {
            ThereAreNoLetters();
        } else if (count == 1)
        {
            ThereIsOneLetter();
        } else
        {
            ThereAreManyLetters(count);
        }
    
    }

    private void ThereAreNoLetters()
    {
        _number = "no";
        _verb = "are";
        _pluralModifier = "s";
    }
    
    private void ThereIsOneLetter()
    {
        _number = "1";
        _verb = "is";
        _pluralModifier = "";
    }

    private void ThereAreManyLetters(int count)
    {
        _number = count.ToString();
        _verb = "are";
        _pluralModifier = "s";
    }
}