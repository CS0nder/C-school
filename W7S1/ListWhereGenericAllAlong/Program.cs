/*Learning goals:

    generic fields
    generic methods

Create the class ListWrapper with one generic private field: _myList,
which is of type List with a generic type. Its constructor simply initializes this field.

Add the following members:

    Add: a method that adds the provided parameter to _myList. Think--what type should the parameter have?
    Get: a method that returns the element of _myList on the provided index. You don't need to check whether this index is valid.
    Count: a property that returns the number of elements in _myList.

*/
public class Program
{
    public static void Main()
    {
        ListWrapper<int> listInt = new();
        listInt.Add(1);
        listInt.Add(2);
        listInt.Add(3);

        for (int i = 0; i < listInt.Count; i++)
            Console.WriteLine(listInt.Get(i));

        ListWrapper<string> listString = new();
        listString.Add("Hello");
        listString.Add("World!");

        for (int i = 0; i < listString.Count; i++)
            Console.WriteLine(listString.Get(i));
    }
}