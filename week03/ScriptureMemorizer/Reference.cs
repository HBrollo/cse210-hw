class Reference()
{
    /*Reference: Keeps track of the book, chapter, and verse information.*/
    private string _book = "Proverbs";
    private int _chapter = 3;
    private int _verse = 5;
    private int _endVerse = 6;

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}: {_verse}-{_endVerse}";
    }
}