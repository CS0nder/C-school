/*Write a program which asks for a direction, either up, down, right or left (case should not matter). Use a switch statement in your solution.

Given an X and Y position which start at x = 0 and y = 0, if the user enters:

    Up -> increase y by 1
    Down -> reduce y by 1
    Right -> increase x by 1
    Left -> decrease x by 1
    If any other value is given, print "Invalid direction", otherwise print the current x and y values.*/


Console.WriteLine("which direction would you like to go?");
string Direction = Console.ReadLine();
int x = 0;
int y = 0;
switch(Direction.ToLower())
{
    case "up":
        y = +1;
        break;
    case "down":
        y = -1;
        break;
    case "right":
        x = +1;
        break;
    case "left":
        x = -1;
        break;
    default:
        Console.WriteLine("Invalid direction");
        break;

}
Console.WriteLine($"current position\nX:{x}, Y:{y}");
