using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "apple", "banana", "cat", "dog", "deer", "elephant", "doctor", "dad", "deadline" };

        string firstWord = words.OrderBy(w => w).First();
        Console.WriteLine($"The word that comes alphabetically before all other words: {firstWord}");

        string[] wordsWithTwoDs = words.Where(w => w.Count(c => c == 'd') == 2).ToArray();
        Console.WriteLine("Words that have exactly two 'd' characters:");
        foreach (var word in wordsWithTwoDs)
        {
            Console.WriteLine(word);
        }
    }
}
