using System;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

class WordList
{
    private Random r = new Random();
    private string[] WordsToGuess;
    public string SecretWord { get; set; }

    public WordList()
    {
        // use resource world list and extract array of trimmed words
        // split on carriage return and new line characters and ignore empty entries
        WordsToGuess = HangMan.Properties.Resources.words.Split(new char[] { '\r', '\n' },
                                                                StringSplitOptions.RemoveEmptyEntries)
                                                                .Select(t => t.Trim()).ToArray();

        ResetSecretWord();
    }

    public void ResetSecretWord()
    {   // set secret word
        SecretWord = WordsToGuess[r.Next(0, WordsToGuess.Length - 1)]; 
    }

    public void TestThis()
    {
        List<String> words;
        words = new List<String>();

        Assembly assembly = Assembly.GetExecutingAssembly();
        //Stream stream = assembly.GetManifestResourceStream(assembly.GetName().Name + '.words');

        //StreamReader sr = new StreamReader(stream);

        //string newWord = sr.ReadLine();

        //    while (newWord != null)
        //    {
        //        words.Add(newWord.ToUpper());
        //        newWord = sr.ReadLine();
        //    }
    }

    internal static string GetFromResources(string resourceName)
    {
        Assembly assem = Assembly.GetExecutingAssembly();

        using (Stream stream = assem.GetManifestResourceStream(assem.GetName().Name + '.' + resourceName))
        {
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }

}

