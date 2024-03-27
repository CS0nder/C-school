/*Learning goals:

    create instances of classes inside a constructor

In Song.cs, create the class Song. It has two fields:

    Title (a string)
    Singer (an Artist)

Its constructor takes one parameter: a string, which is this Song's Title. Also create a new instance of Artist, with the Name being Unknown.

Also give this class two methods:

    SetSinger: takes an Artist as a parameter; set this Song's Singer to this Artist.
    Info: takes no parameters and returns the Title and the Artist of this Song Artist
        For example: Bohemian Rhapsodiy is by Queen

*/

class Song
{
    public string Title;
    public Artist Singer;

    public Song(string title)
    {
        this.Title = title;
        this.Singer = new Artist("Unkown");

    }
    public void SetSinger(Artist singer)
    {
        this.Singer = singer;
    }
    public string Info() => $"{Title} is by {Singer.Name}";
}