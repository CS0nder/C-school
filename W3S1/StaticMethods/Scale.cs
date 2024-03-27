/*
class Scale 
{
    public static bool UseKg = true;
    public static double ConvertKgToLbs(double weight)
    {
        return weight * 2.2;
    }
    public static string DisplayWeight(double weight)
    {
        if (weight == 60 && UseKg)
        {
            return $"{weight} kg";

        }
        else
        {
            return $"{ConvertKgToLbs(weight)} lbs";
        }
    }
}


/*
Create the class Scale with one field: bool UseKg, which is initialized to true. It has two methods:

    ConvertKgToLbs: a static method that takes a double and returns it multiplied by 2.2.
    DisplayWeight: takes one double and returns a string. If the double is 60 and UseKg is
        true: return 60 kg
        false: return 132 lbs (in this case, 60 was converted to 132 using ConvertKgToLbs)

*/

class Scale 
{
    public bool UseKg = true;
    public static double ConvertKgToLbs(double weight)
    {
        return weight * 2.2;
    }
    public string DisplayWeight(double weight)
    {
        if (weight == 60 && UseKg)
        {
            return $"{weight} kg";

        }
        else
        {
            return $"{ConvertKgToLbs(weight)} lbs";
        }
    }
}

