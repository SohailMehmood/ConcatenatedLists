using System;
using System.Collections.Generic;

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

        List<string> numbers = new()
        {
            "1",
            "2",
            "3"
        };

        letters.AddRange(numbers);
        Console.WriteLine(String.Join(",", letters));
    }
}