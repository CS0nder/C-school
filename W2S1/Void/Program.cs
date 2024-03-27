﻿/* Learning goals:

    void methods

Write a program that has a class (named Program for example).
Within this class, create a public static void Main method.
If there is a Main method, it will be the entry point of the program.

Then create a method called PrintFullName.
Like the Main method, it is public, static and void.
This method has two string parameters: firstName and lastName.
It prints the full name, which is the first name and the last name, separated by a space.

From the Main method, call PrintFullName with "John" and "Doe". The output of this program should then be John Doe.*/
class Program
{
    public static void Main(string[] args)

    {
        string firstName = "John";
        string lastName = "Doe";
        PrintFullName(firstName,lastName);
      

    }
    public static void PrintFullName(string firstName, string lastName)
    {
        Console.WriteLine($"{firstName} {lastName}");
    }
}
