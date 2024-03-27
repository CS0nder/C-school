class Ventilator
{
    public int Speed;
    public List<Button> Buttons;

    public Ventilator() => Buttons = new List<Button>()
        { new Button(), new Button(), new Button(), new Button() };

    public void PressButton(int number)
    {
        for (int i = 0; i < Buttons.Count; i++)
        {   
            if (number < 0 ||  number >= number.Count);
                return;
            // als de nummer 0 is zijn alle buttons false want dan word het als eerst ingeklikt
            if (number == 0 )
            {
                Buttons[i].IsPressed = false;
            }
            //kijkt of de nummber met de index klopt om te kijken welkje button er word geklikt en de speed word de index van de button
            else if (number == i)
            {
                Buttons[i].IsPressed = true;
                Speed = i;
            }
            // als geen 1 klopt word er niet op de button van i gedrukt dus word het false zodat er niet op de verkeerde button word ingedrukt
            else
            {
                Buttons[i].IsPressed = false;
            }
  
        }
    }

    public string Blow() => Speed switch
    {
        <= 0 => "Off",
           1 => "~~~",
           2 => "^^^",
        >= 3 => "===",
    
    };
}


/*Class Ventilator has a List of four Buttons. A Button has a field IsPressed, which is a bool. They can be pressed through the Ventilator's PressButton method:

    Pressing the first button depresses (IsPressed = false) all buttons;
    Pressing any other button presses that button (IsPressed = true) and depresses all other buttons. It also sets the Speed to the index of that Button.

    However, the Ventilator class has a number of issues that you should fix:

    calling method PressButton can result in an ArgumentOutOfRangeException. Make it so that these numbers are ignored instead (so just return).
    after pressing any of the Ventilator's Buttons, the output of Blow is always === for some reason.

*/