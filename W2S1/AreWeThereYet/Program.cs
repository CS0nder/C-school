
public class Location
{
    public int ID;
    public string Name;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;

    public Location(int id, string name)
    {
        ID = id;
        Name = name;
    }

    public string Compass()
    {
        //Settings > Debug > Console: Collapse Identical Lines
        string s = "From here you can go:\n";
        if (LocationToNorth != null)
        {
            s += "    N\n    |\n";
        }
        if (LocationToWest != null)
        {
            s += "W---|";
        }
        else
        {
            s += "    |";
        }
        if (LocationToEast != null)
        {
            s += "---E";
        }
        s += "\n";
        if (LocationToSouth != null)
        {
            s += "    |\n    S\n";
        }
        return s;
    }

    public Location GetLocationAt(string location)
    {
        if (location == "N") return LocationToNorth;
        if (location == "E") return LocationToEast;
        if (location == "S") return LocationToSouth;
        if (location == "W") return LocationToWest;
        return null;
    }
}



public class Player
{
    public Location CurrentLocation;
    public Player(Location currentLocation)
    {
        CurrentLocation = currentLocation;
    }

    public bool TryMoveTo(Location newLocation)
    {
        if (newLocation != null)
        {
            CurrentLocation = newLocation;
            return true;
        }
        return false;
    }
}

/* Below is a map of 6 Locations.
 * The Player starts at 1 and the goal is to move to 6.
 * +---+
 * |123|
 * | 4 |
 * | 56|
 * +---+
 */

Player player = new Player(); //Creates a Player object and puts him at Location 1
player = player(World.Locations[0]);
Console.WriteLine("Current location: " + player.CurrentLocation.Name);
Console.WriteLine(player.CurrentLocation.Compass()); //Can be used to see the movement options

player.TryMoveTo(player.CurrentLocation.GetLocationAt("E")); //Moves the Player to Location 2

/*
 * Write a while-loop that continues until the Player has arrived at the Goal.
 * This means that the Player's CurrentLocation Name should become "Goal".
 * At each iteration, ask the user for a direction (N/E/S/W), then try to move the Player.
 * For example:
 * - player.TryMoveTo(player.CurrentLocation.GetLocationAt("N")) will move the Player north IF there is a Location;
 * - player.TryMoveTo(null) will not move the Player.
 */

// VVV YOUR CODE GOES HERE VVV
while (player.CurrentLocation.Name != "Goal")
{   
    Console.WriteLine("Which direction do you want to go to? (N/E/S/W)");
    string direction = Console.ReadLine();
    switch (direction)
    {
        case "N":
        if (player.TryMoveTo(player.CurrentLocation.LocationToNorth))
        {
            Console.WriteLine("Moved north");
        }
        else
        {
            Console.WriteLine("Cannot go north");
        }
        break;
        case "E":
        if (player.TryMoveTo(player.CurrentLocation.LocationToEast))
        {
            Console.WriteLine("Moved east");
        }
        else
        {
            Console.WriteLine("Cannot go east");
        }
        break;
        case "S":
        if (player.TryMoveTo(player.CurrentLocation.LocationToSouth))
        {
            Console.WriteLine("Moved south");
        }
        else 
        {
            Console.WriteLine("Cannot go south");
        }
        break;
        case "W":
        if (player.TryMoveTo(player.CurrentLocation.LocationToWest))
        {
            Console.WriteLine("Moved west");
        }
        else
        {
            Console.WriteLine("Cannot go west");
        }
        break;
        
}


// ^^^YOUR CODE GOES HERE ^^^

Console.WriteLine("You have arrived at the goal!");


public static class World
{
    public static readonly List<Location> Locations = new List<Location>();

    public const int LOCATION_ID_LOC1 = 1;
    public const int LOCATION_ID_LOC2 = 2;
    public const int LOCATION_ID_LOC3 = 3;
    public const int LOCATION_ID_LOC4 = 4;
    public const int LOCATION_ID_LOC5 = 5;
    public const int LOCATION_ID_LOC6 = 6;

    static World() => PopulateLocations();

    private static void PopulateLocations()
    {
        // Create each location
        Location loc1Start = new Location(LOCATION_ID_LOC1, "Start");
        Location loc2      = new Location(LOCATION_ID_LOC2, "Empty location");
        Location loc3      = new Location(LOCATION_ID_LOC3, "Empty location");
        Location loc4      = new Location(LOCATION_ID_LOC4, "Empty location");
        Location loc5      = new Location(LOCATION_ID_LOC5, "Empty location");
        Location loc6Goal  = new Location(LOCATION_ID_LOC6, "Goal");

        /* Map of locations
         * +---+
         * |123|
         * | 4 |
         * | 56|
         * +---+
         */

        // Link the locations together
        loc1Start.LocationToEast = loc2;

        loc2.LocationToEast = loc3;
        loc2.LocationToSouth = loc4;
        loc2.LocationToWest = loc1Start;

        loc3.LocationToWest = loc2;

        loc4.LocationToNorth = loc2;
        loc4.LocationToSouth = loc5;

        loc5.LocationToNorth = loc4;
        loc5.LocationToEast = loc6Goal;

        loc6Goal.LocationToWest = loc5;

        Locations.Add(loc1Start);
        Locations.Add(loc2);
        Locations.Add(loc3);
        Locations.Add(loc4);
        Locations.Add(loc5);
        Locations.Add(loc6Goal);
    }
}