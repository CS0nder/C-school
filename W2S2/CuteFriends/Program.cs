

class Program
{   

    public static void Main()
    {   List<Pet> Pets = new List<Pet>{};

        Pet pet1 = new Pet("Dog", "Nugent");
        Pet pet2 = new Pet("Cat", "Steve");
        Pet pet3 = new Pet("Goldfish", "Brutus");
        Pets.Add(pet1);
        Pets.Add(pet2);
        Pets.Add(pet3);

        Person johnObj = new Person("John", Pets);
        foreach (Pet pet in johnObj.Pets)
        {
            Console.WriteLine($"{johnObj.Name} has a {pet.WhatAmI} named {pet.Name}");
        }
    }
}


