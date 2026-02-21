public class Word
{
    private string _verse;
    private string[] _splitVerse;
    private bool[] _isHidden;
    private string _mask;
    private List<int> _location;




    public Word()
    {
        _mask = "____________________________";
        _verse = "Now, as my mind caught hold upon this thought, I cried within my heart: O Jesus, thou Son of God, have mercy on me, who am in the gall of bitterness, and am encircled about by the everlasting chains of death.";
        _location = new List<int>();

    }

    public string[] SplitWords(string verse)
    {

        string[] splitVerse = verse.Split(" ");

        _splitVerse = splitVerse;

        RandWordSpot();

        //Console.WriteLine($"isHidden: {string.Join(", ", _isHidden)}");


        return _splitVerse;
    }

    public void RandWordSpot()
    {
        Random rand = new Random();

        int spot = 0;

        _isHidden = new bool[_splitVerse.Length];

        for(int i = 0; i <= 4; i++)
        {
            spot = rand.Next(0, _splitVerse.Length);

            while(_location.Contains(spot) & _location.Count != _splitVerse.Length)
            {
                spot = rand.Next(0, _splitVerse.Length);

            }

        }

        if (! _location.Contains(spot))
        {
            _location.Add(spot);
        }


        foreach(int pos in _location)
        {
            _isHidden[pos] = true;
        }

        for (int i = 0; i < _location.Count; i++){
            _isHidden[_location[i]] = true;
        }
    }

    public string GetVerse()
    {
        return _verse;
    }

    public bool GetRandWordSpot(int ptr)
    {
        return _isHidden[ptr];
    }

    public List<int> GetRandWordList()
    {

        //Console.WriteLine($"[{string.Join(", ", _location)}]");

        return _location;
    }

    public string GetSplitWords(int ptr)
    {
        return _splitVerse[ptr];
    }

    public string Getmask(int l)
    {
        return _mask.Substring(0,l);
    }




}