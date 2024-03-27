
class Person
{
    public string Name;
    public Animal Pet;

    public Person(string name, Animal pet)
    {
        Name = name;
        Pet = pet;
    }
    public string Info()
    {
        string info;

        if (!Pet == null)
            {
                info = $"{Name} has no pet";            
            }
 
        else
            {
                info = $"{Name} has a pet that makes the sound {Pet.MakeSound}";
            }
        return info;
    }
}


//In dit statement (line 15) maak je ook gebruik van de Pet member.
//Je roept namelijk de MakeSound() method aan in een Pet object. Wanneer Pet echter null is, dan kan dat niet.
//De variabele/member is namelijk expliciet op null gezet -->
// expliciet toegewezen als 'ik verwijs niet naar een object'.