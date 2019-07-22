using System;
using System.Text.RegularExpressions;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
            var str = Console.ReadLine(); 
            Console.WriteLine("Enter a word to search: ");
            var word = Console.ReadLine();
            var wordFound = Regex.Matches(str, word).Count;
            Console.WriteLine("Word found {0} times in the string", wordFound);
        }
    }
}