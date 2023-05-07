using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, string chapter, int singleVerse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = singleVerse;
        _verseEnd = singleVerse;
    }

    public Reference(string book, string chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetReference()
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}
