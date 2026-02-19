public class Reference
{
    private string _refBook;
    private string _refChap;
    private string _refVerses;

    public Reference()
    {
        _refBook = "Alma";
        _refChap = "36";
        _refVerses ="18";
    }



    public void SetReference(string refBook, string refChap, string refVerses)
    {
        _refBook = refBook;
        _refChap = refChap;
        _refVerses = refVerses;
    }
    public string GetReference()
    {
        return $"{_refBook} {_refChap}:{_refVerses}";
    }


}