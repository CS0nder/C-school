/*Learning goal:

    optional default constructor

Create a class Button with the fields IsPressed (bool) and TimesPressed (int).
Their values should start at their default values, which are false and 0, respectively.

This also means the constructor has no parameters and has nothing to do.
In a case like this, the constructor does not have to be written explicitly, although it is recommended that you do.
For this assignment, you may either include or leave out the constructor.

It has two methods:

    Press: changes IsPressed from true to false and vice versa. Also increments TimesPressed by 1.
    Info: returns the state of IsPressed and how many times this Button has been Pressed. Two examples:

Button is not pressed.
Pressed 4 times.

Button is pressed.
Pressed 5 times.

You can use the following code to test your application:
*/
class Program
{
    public static void Main()
    {
        Console.WriteLine("Press how many times?");
        var pressHowManyTimes = Convert.ToInt32(Console.ReadLine());
        Button button = new();
        for (int i = 0; i < pressHowManyTimes; i++)
            button.Press();

        Console.WriteLine(button.Info());
    }
}

class Button
{
    bool IsPressed;
    int TimesPressed;
    public void Press()
    {
        if (IsPressed == true)
        {
            IsPressed = false;
            TimesPressed++;
        }
        else
        {
            IsPressed = true;
            TimesPressed++;
        }
    }
    public string Info()
    {
        if (IsPressed)
        {
            return $"Button is pressed\nPressed {TimesPressed} times)";
            
        }
        else
        {
            return $"Button is not pressed\nPressed {TimesPressed} times";
        }
    }
}