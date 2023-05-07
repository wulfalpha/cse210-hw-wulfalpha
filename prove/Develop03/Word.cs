using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public bool IsHidden => _isHidden;

    public string GetWord()
    {
        return _word;
    }

    public void SetHidden()
    {
        _isHidden = true;
    }

    public static List<Word> ParseScripture(string scripture)
    {
        List<Word> words = new List<Word>();
        string[] wordStrings = scripture.Split(' ');

        foreach (string wordString in wordStrings)
        {
            Word word = new Word(wordString);
            if (wordString.StartsWith("*"))
            {
                word.SetHidden();
            }
            words.Add(word);
        }

        return words;
    }
}
