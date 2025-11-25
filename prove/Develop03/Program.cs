using System;
using System.Collections.Generic;


class Program
{
    private static Scripture _scripture0 = new Scripture("1 Nephi", 3, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
    private static string _reference = _scripture0.GetReference();
    private static string _words = _scripture0.GetWords();
    private static string _allCurrentScripture = string.Concat(_reference, " ", _words);

    static void Main(string[] args)
    {
        string option = "N/A";
        while (option != "quit" && (_scripture0.GetWordsCount() != _scripture0.GetIndexesofHiddenCount()))
        {
            Console.Clear();
            string rendered = string.Concat(_scripture0.GetReference(), " ", _scripture0.GetWords());
            Console.WriteLine(rendered);
            Console.WriteLine("Please press enter to hide words, type 'hint' to get hints or 'quit' to exit: ");
            option = Console.ReadLine();

            if (option == "")
            {
                Random rng = new Random();

                int randomIndex1 = rng.Next(0, _scripture0.GetWordsCount());
                _scripture0.SetWordHidden(randomIndex1);
                _scripture0.AddToIndexesofHidden(randomIndex1);

                int randomIndex2 = rng.Next(0, _scripture0.GetWordsCount());
                _scripture0.SetWordHidden(randomIndex2);
                _scripture0.AddToIndexesofHidden(randomIndex2);

                int randomIndex3 = rng.Next(0, _scripture0.GetWordsCount());
                _scripture0.SetWordHidden(randomIndex3);
                _scripture0.AddToIndexesofHidden(randomIndex3);
            }
            else if (option == "hint")
            {
                List<int> indexes = _scripture0.GetIndexesofHidden();
                
                foreach (int index in indexes)
                {
                    _scripture0.SetWordHinted(index);
                }
            }

        }
    }
}