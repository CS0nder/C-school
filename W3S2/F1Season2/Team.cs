/*Given Program.cs, write a program that matches the output.

A couple of pointers:

   
    The race outcomes are random.
    The first 10 racers to finish a race get the following amount of points, from 1st to 10th: 25, 18, 15, 12, 10, 8, 6, 4, 2, 1.
    In the season results, drivers are listed from most points to least.

Example output:

Kevin Magnussen of Haas-Ferrari has won the Bahrain Grand Prix!
Louis Hamilton of Mercedes-AMG has won the Saudi Arabia Grand Prix!
Sergio Perez of Red Bull Racing has won the Australia Grand Prix!
Charles Leclerc of Ferrari has won the Emilia Romagna Grand Prix!
Pierre Gasly of AlphaTauri-Red Bull has won the Miami Grand Prix!
Mick Schumacher of Haas-Ferrari has won the Spain Grand Prix!
Daniel Ricciardo of McLaren-Mercedes has won the Monaco Grand Prix!
Kevin Magnussen of Haas-Ferrari has won the Azerbaijan Grand Prix!
Pierre Gasly of AlphaTauri-Red Bull has won the Canada Grand Prix!
Louis Hamilton of Mercedes-AMG has won the Great Britain Grand Prix!
Esteban Ocon of Alpine-Renault has won the Austria Grand Prix!
George Russel of Mercedes-AMG has won the France Grand Prix!
Nicholas Latifi of Williams-Mercedes has won the Hungary Grand Prix!
Pierre Gasly of AlphaTauri-Red Bull has won the Belgium Grand Prix!
George Russel of Mercedes-AMG has won the Netherlands Grand Prix!
Guanyu Zhou of Alfa Romeo Racing-Ferrari has won the Italy Grand Prix!
Valtteri Bottas of Alfa Romeo Racing-Ferrari has won the Singapore Grand Prix!
Daniel Ricciardo of McLaren-Mercedes has won the Japan Grand Prix!
Sergio Perez of Red Bull Racing has won the United States Grand Prix!
Max Verstappen of Red Bull Racing has won the Mexico Grand Prix!
Guanyu Zhou of Alfa Romeo Racing-Ferrari has won the Brazil Grand Prix!
George Russel of Mercedes-AMG has won the Abu Dhabi Grand Prix!

Season results:
 1. Sergio Perez: 182
 2. Guanyu Zhou: 172
 3. Pierre Gasly: 150
 4. Daniel Ricciardo: 136
 5. Charles Leclerc: 135
 6. George Russel: 124
 7. Sebastian Vettel: 113
 8. Lance Stroll: 111
 9. Louis Hamilton: 104
10. Mick Schumacher: 104
11. Fernando Alonso: 103
12. Max Verstappen: 102
13. Kevin Magnussen: 96
14. Carlos Sainz Jr.: 90
15. Alex Albon: 89
16. Esteban Ocon: 86
17. Lando Norris: 84
18. Nicholas Latifi: 84
19. Valtteri Bottas: 83
20. Yuki Tsunoda: 74 */




class Team
{


    public string Name;
    public List<Driver> Drivers = new List<Driver>();
    public Team(string name)
    {
        this.Name = name;
    }

 
    
    public void ContractDriver(Driver name)
    {
        Drivers.Add(name);
    }
}
     





