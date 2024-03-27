/*This class has one field: a List of Books. This class can be instantiated by either providing a List of Books, or no parameter at all.

This class has two methods:

    AddBook: a Book can be added to the Library by providing this method with either:
        a Book instance, or
        an ID and a Title.
    FindBook: given an ID, look through the Books and return the first Book instance found with this ID, or null. The given ID can be either:
        an int, or
        a string. In this case you are expected to handle any necessary exceptions and notify the user that the given ID was invalid (i.e. not a number).

*/



public class Library
{

    public List<Book> listOfBooks = new List<Book>();

 
    public void AddBook(Book book)
    {
        listOfBooks.Add(book);
    }

    public void AddBook(int id, string title)
    {   
        Book book = new Book(id,title);
        listOfBooks.Add(book);
    }

    public Book? FindBook(int id)
    {   
        //zoek in de lijst waar book book id is
        return listOfBooks.Find(book => book.ID == id);
    }

    
    public (Book? book, string? error) FindBook(string id)
    {   
        if (int.TryParse(id, out int newID))
        {
            return (FindBook(newID), null);
        }
        else
        {
            return (null, "Given invalid ID");
        }
    }
}