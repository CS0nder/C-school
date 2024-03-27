
class Program
{
    public static void Main()
    {
        Ventilator ventilator = new();
        for (int i = -1; i <= 4; i++)
        {
            ventilator.PressButton(i);
            Console.WriteLine(ventilator.Blow());
        }
    }
}

/*Class Ventilator has a List of four Buttons. A Button has a field IsPressed, which is a bool. They can be pressed through the Ventilator's PressButton method:

    Pressing the first button depresses (IsPressed = false) all buttons;
    Pressing any other button presses that button (IsPressed = true) and depresses all other buttons. It also sets the Speed to the index of that Button.

However, the Ventilator class has a number of issues that you should fix:

    calling method PressButton can result in an ArgumentOutOfRangeException. Make it so that these numbers are ignored instead (so just return).
    after pressing any of the Ventilator's Buttons, the output of Blow is always === for some reason.

*/