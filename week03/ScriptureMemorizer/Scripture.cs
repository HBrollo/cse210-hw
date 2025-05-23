using System;
class Scripture()
{
    /*Scripture: Keeps track of both the reference and the text of the scripture.
     Can hide words and get the rendered display of the text.*/
    public List<Word> _words = new List<Word>();
    private string[] _fullScripture = ["Trust", "in", "the", "Lord", "with", "all", "thine",
        "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding.",
        "In", "all", "thy", "ways", "acknowledge", "him,", "and", "he", "shall", "direct", "thy", "paths."];

    public void ConstructList()
    {
        foreach (string scripture in _fullScripture)
        {
            Word word = new Word();
            word._text = scripture;
            word._isHidden = false;
            _words.Add(word);
        }
    }


    public void GetDisplayText(Reference _reference)
    {
        Console.Write($"{_reference.GetDisplayText()}:");
        foreach (Word word in _words)
        {
            Console.Write($" {word._text}");
        }
    }

    public bool HideRandomWord(int randomIndex, bool loop)
    {
        if (_words[randomIndex]._isHidden == false)
        {
            _words[randomIndex]._isHidden = true;
            loop = false;
            _words[randomIndex]._text = _words[randomIndex].Hide(randomIndex, _words[randomIndex]._text);
            return loop;
        }
        return loop;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word._isHidden == false)
            {
                return false;
            }
        }
        return true;
    }

}
