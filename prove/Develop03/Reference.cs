public class Reference
{
    private string _refBook;
    private string _refChap;
    private string _refBeginVerse;
    private string _refEndVerse;


    public Reference()
    {
        _refBook = "Alma";
        _refChap = "36";
        _refBeginVerse = "18";
    }

    public Reference(string refEndVerse)
    {
        _refBook = "Alma";
        _refChap = "36";
        _refBeginVerse = "18";
        _refEndVerse = refEndVerse;
    }

    public void SetReference(string refBook, string refChap, string refBeginVerse, string refEndVerse)
    {
        _refBook = refBook;
        _refChap = refChap;
        _refBeginVerse = refBeginVerse;
        _refEndVerse = refEndVerse;
    }
    public string GetReference()
    {
        if (_refEndVerse == null){
            return $"{_refBook} {_refChap}:{_refBeginVerse}";
        }
        else
        {
            return $"{_refBook} {_refChap}:{_refBeginVerse}-{_refEndVerse}";
        }
    }


}