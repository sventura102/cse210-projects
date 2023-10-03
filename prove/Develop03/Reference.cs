public class Reference {
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;

    public Reference(string _book, int _chapter, int _verse) {
        _book = "Proverbs";
        _chapter = 17;
        _verse = 17;
    }
    public Reference(string _book, int _chapter, int _verse, int _endVerse) {
        _book = "Proverbs";
        _chapter = 17;
        _verse = 17;
        _endVerse = 18;
    }
    public string GetDisplayText() {
        string text = $"{_book} {_chapter}:{_verse}";
        return text;
    }
}