public static class RewardGenerator<T>
{
    public static Random random = new Random(0);

    public static T GetRandomElement(List<T> list)
    {   
        int index = random.Next(list.Count());
        return list[index];
    }
    

}

/*Learning goals:

    generic methods that define their own generic type

Create the static class RewardGenerator. Give it a Random object field/property with the seed 0.

Give this class a generic method named GetRandomElement that takes a List of any type. It returns a random element of this List.
*/



