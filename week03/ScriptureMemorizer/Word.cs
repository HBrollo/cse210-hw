public class Word()
{
    /*Word: Keeps track of a single word and whether it is shown or hidden.*/
    public string _text;
    public bool _isHidden;

    private string[] hiddenScripture =
    ["_____", "__", "___", "____", "____", "___","_____", "_____;", "___",
    "____","___", "____", "_____", "___", "_____________.",
    "__", "___", "___", "____", "__________", "___,", "___", "__", "_____", "______", "___", "_____."];

    public string Hide(int index, string wordToHide)
    {
        wordToHide = hiddenScripture[index];
        return wordToHide;
    }



}