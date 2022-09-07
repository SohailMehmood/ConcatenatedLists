using System;

namespace ConcatenatesLists;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args == null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        List<string> letters = new()
        {
            "a",
            "b",
            "c"
        };

        List<int> numbers = new()
        {
            1,
            2,
            3
        };

        List<string> convertedNumbers = numbers.ConvertAll<string>(x => x.ToString());

        letters.AddRange(convertedNumbers);
        Console.WriteLine(String.Join(",", letters));

        var result = letters.Concat(convertedNumbers).ToList();

        List<string> concatenatedList = result.ToList();

        foreach (string s in concatenatedList)
        {
            Console.Write($"{s}, ");
        }
    }
}