// Production Code
// After demo copy RefactorCleanCodeSource to start over
// to test this code use RefactorCleanCodeTest
/*
 * 1 nombres
 *      retorna un mensaje
 */

using ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        String s;
        GuessLetters gl = new GuessLetters();
        // Clean Code Book Chapter 2
        s = gl.GetGuessStatistics('C', 4);
        Console.WriteLine(s);

        s = gl.GetGuessStatistics('E', 3);
        Console.WriteLine(s);
        s = gl.GetGuessStatistics('D', 4);
        Console.WriteLine(s);
    }
    
 
}