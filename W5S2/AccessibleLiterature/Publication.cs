

class Publication
{
    public string Publisher;
    public string Title;
    private int _pages;
    public string PublicationType;
    public DateTime PublicationDate;

    protected List<string> Audience = new List<string>();
    protected bool IsPublished = true;

    public int Pages
    {
        get {return _pages;}
        set
        {
            if (value <= 0)
            {
                Pages = 1;
            }
            else
            {
                Pages = value;
            }
        }
    }

    private DateTime? _publishedOn;
    public virtual string PublishedOn
    {
        get {return PublishedOn;}
        set
        {
            if (_publishedOn.HasValue)
            {   
        
                return _publishedOn.Value.ToString("yyyy-MM-dd");
            }
            else
            {
                return "not published yet";
            }
        }
    }

    public Publication(string title, string publisher, string PubType, List<string> audience)
    {
        Title = title;
        Publisher = publisher;
        PublicationType = PubType;
        Audience = audience;
    }

    public bool IsSuitableForAudience(string audience)
    {
        foreach (string au in Audience)
        {
            if (au == audience)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public override string ToString()
    {
        return $"{PublishedOn},{Pages}"
    }
}