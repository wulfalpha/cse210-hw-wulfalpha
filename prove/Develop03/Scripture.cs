using System;

public class Scripture
{
    private readonly List<Word> _wordList;
    private Reference _scriptureReference;

    public Scripture(Reference reference, string text)
    {
        _scriptureReference = reference;
        _wordList = Word.ParseScripture(text);
    }

    public string GetScriptureReference()
    {
        return string.Join(" ", _scriptureReference.GetReference(), ":",
                           string.Join(" ", _wordList.Select(word => word.GetWord())));
    }


    public bool HasHiddenWords()
    {
        return _wordList.Exists(word => word.IsHidden);
    }

    public void RemoveFirstWord()
    {
        _wordList.RemoveAt(0);
    }
}
