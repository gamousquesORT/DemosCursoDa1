namespace ConsoleApp1;

public class GuessLetters
{
    public  string GetGuessStatistics(char candidate, int count)
    {
        string number;
        string verb;
        string pluralModifier;

        if (count < 0)
        {
            throw new ArgumentException("Count cannot be negative");
        } else if (count == 0)
        {
            number = "no";
            verb = "are";
            pluralModifier = "s";
        } else if (count == 1)
        {
            number = "1";
            verb = "is";
            pluralModifier = "";
        } else
        {
            number = count.ToString();
            verb = "are";
            pluralModifier = "s";
        }
        return $"There {verb} {number} {candidate}{pluralModifier}";
    }


    /*
    public  string GetGuessStatistics(char candidate, int count)
    {
        if (count < 0)
        {
            throw new ArgumentException("Count cannot be negative");
        }

        string number = count == 0 ? "no" : count.ToString();
        string verb = count == 1 ? "is" : "are";
        string pluralModifier = count == 1 ? "" : "s";

        return $"There {verb} {number} {candidate}{pluralModifier}";
    }
    */
}