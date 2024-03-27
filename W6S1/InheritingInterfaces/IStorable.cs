/*Learning goals:

    creating interfaces that inherit from other interfaces

Create two new files: IStorable.cs and IDocument.cs. In each file, create an interface of the same name (without the .cs).

In IStorable, define the following members:

    string FileName, a readable and writable property
    a method Load that takes no parameters and returns nothing
    a method Save that takes no parameters and returns nothing

IDocument inherits from IStorable. In this interface, define the following members:

    string Title, a property with an auto-implemented get and set
    string Content, a property with an auto-implemented get and set
    a method Print that takes no parameters and returns nothing

*/

interface IStorable
{
    string FileName {get;set;}

    void Load();
    void Save();
}