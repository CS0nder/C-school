/*For this assignment you are expected to hand-in the following files:

    Book.cs
    Program.cs
    BookCollectionTest.cs 

Write a program that uses JSON named books.json to keep track of information about a collection of books, including the title, author, and publication year.
Your program should be able to:
 read the JSON file,
 display the book information to the user,
 and allow the user to add new books to to the collection,
 or remove them.

Before you start coding on your program, inspect the test methods to have a starting point on how to structure your program code.


Note that your program will be tested to see whether it will result in any of the following exceptions when dealing with the user's input:

    FormatException
    IndexOutOfRangeException
    ArgumentOutOfRangeException

And also these when handling the JSON file:

    FileNotFoundException (print "Missing JSON file. " followed by the Message)
    JsonReaderException (print "Invalid JSON. " followed by the Message)
    In either case the program should simply continue with no books.

Here is the JSON file contents with the books the user currently has:


Here is an example of how the program could be used:
Book Collection:
1. The Great Gatsby by F. Scott Fitzgerald (1925)
2. To Kill a Mockingbird by Harper Lee (1960)
3. 1984 by George Orwell (1949)

What would you like to do?
+: add a new book
-: remove a book
A number: see information on this book
q: quit
>+
*/

using Newtonsoft.Json;

class Program
{   
    
    public string fileName = "books.json";
    public List<Books> listOfBooks = new List<Books>();
    
    public static void Main()
    {   
        Program prog = new Program();

        Console.WriteLine("WHat would you like to do?");
        Console.WriteLine("+: add a new book");
        Console.WriteLine("-: remove a book");
        Console.WriteLine("A number: see information on this book");
        Console.WriteLine("q: quit");
        var Answer = Console.ReadLine();
        while (Answer != "q")
        {

            if (Answer == "+" )
            {
                Console.WriteLine("Enter the title of the new book:");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the author of the new book:");
                string author = Console.ReadLine();
                Console.WriteLine("Enter the publication year of the new book:");
                int year = Convert.ToInt32(Console.ReadLine());
                prog.Add_Book(title,author,year);
                
                
            }
            else if (Answer == "-")
            {
                Console.WriteLine("Enter the number of the book to remove:");

            }
            else if (int.TryParse(Answer, out int bookNumber))
            {

            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
    public void ReadFile(string fileName)
    {   
        StreamReader reader = new StreamReader(fileName);
        string File2JSon = reader.ReadToEnd();
        listOfBooks = JsonConvert.DeserializeObject<List<Books>>(File2JSon)!;
        reader.Close();

    }

    //pakt de variable data die moet gescherven worden naar de json file
    public void WriteToFile(List<Books> books)
    {
        StreamWriter writer = new StreamWriter(fileName);
        string List2Json = JsonConvert.SerializeObject(books);
        File.WriteAllText(fileName, List2Json);
        writer.Close();

    }

    public void Add_Book(string title, string author, int year)
    {
        Books book = new Books(title,author,year);
        listOfBooks.Add(book);
        WriteToFile(listOfBooks);

    }

    public void Remove_Book(int number)
    {   
        if (number < 0 || number >= listOfBooks.Count)
        {
            Console.WriteLine("Book does not exist");
        }
        else
        {
            listOfBooks.RemoveAt(number);
            WriteToFile(listOfBooks);
        }

    }
    
    public void Remove_AllBooks()
    {
        listOfBooks.Clear();
        WriteToFile(listOfBooks);

    }
    public Books? Get_Book(string bookTitle)
    {
        foreach (Books book in listOfBooks)
        {
            if(bookTitle == book.Title)
            {
                return book;
            }

        }
        return null;
    }

    public void Get_Books()
    {   
        
    }

    public void Set_Books()
    {

    }

}