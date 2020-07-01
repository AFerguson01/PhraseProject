using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace PhraseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recieve User Input
            Console.Write("Enter a phrase: ");
            var response = Console.ReadLine();

            // Split Input Into Words
            string[] splitResponse = response.Split(" ");

            // Create List
            List<string> words = new List<string>();

            // Convert Words Array To List
            foreach (var word in splitResponse){
                    words.Add(word);
            }

            // Create List Of Duplicate Words
            List<string> duplicateWords = words.GroupBy(x => x).Where(group => group.Count() > 1).Select(group => group.Key).ToList();

            // Remove Duplicate Words
            foreach (var duplicate in duplicateWords){
                words.RemoveAll(words => words == duplicate);
            }

            // Join Words To Form Final String
            string finalPhrase = string.Join(" ", words);


            // Print String
            Console.Clear();
            Console.Write("*** Removing Duplicate Words ***");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Your new phrase is: " + finalPhrase);
            Console.Write("Press Enter to Continue...");
            Console.Read();
        }
    }
}
