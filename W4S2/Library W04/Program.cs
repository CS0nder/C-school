/*
Write two classes: Library and Book.
Book

This class has two fields: ID (an int) and Title (a string). Its constructor needs at least a parameter for the ID; if only the ID is provided,\
it sets the title to Title unknown.

This class has one method:

    Info: returns the ID and Title of the book. For example, if the ID is 1 and the title is "1984", it returns:

ID = 1, Title = 1984

Library

This class has one field: a List of Books. This class can be instantiated by either providing a List of Books, or no parameter at all.

This class has two methods:

    AddBook: a Book can be added to the Library by providing this method with either:
        a Book instance, or
        an ID and a Title.
    FindBook: given an ID, look through the Books and return the first Book instance found with this ID, or null. The given ID can be either:
        an int, or
        a string. In this case you are expected to handle any necessary exceptions and notify the user that the given ID was invalid (i.e. not a number).

*/


public class Book
{
    public int ID;
    public string Title;

    public Book(int id)
    {
        ID = id;
        Title = "Unknown";
    }
    
    public Book(int id, string title)
    {
        ID = id;
        Title = title;
    }

    public string Info()
    {
        return $" ID = {ID}, Title = {Title}";
    }
}