/*Create a program that asks the user to guess a six-letter word and gives them a hint.
 In Python, you have used the len() function to find the length of a string. For this assignment, you will need to find out how to do this in C#.

The program prints:

You have one chance to guess this six-letter word:
Le..th

HINT: this word is used to find the LENGTH of a string!

Depending on the guess, the program gives feedback. Some examples:

    Correct!
    Kind of correct; the case was just wrong (hint: use ToLower())
    Incorrect! That is not even a six-letter word!
    Incorrect!*/

Console.WriteLine("You have one chance to guess this-six letter word:\n Le..th\n Guess:");
string Guess = Console.ReadLine();
if (Guess == "Length")
{
    Console.WriteLine("Correct!");
}
else if (Guess == "length")
{
    Console.WriteLine("Kind of correct; the case was just wrong (hint: use ToLower())");
}
else if (Guess.Length < 6)
{
    Console.WriteLine("Incorrect! That is not even a six-letter word!");
}
else
{
    Console.WriteLine("Incorrect!");
}