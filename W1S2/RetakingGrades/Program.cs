

string answer = "";
List<double> grades = new List<double> {6.5, 9.5, 4, 5, 4.5, 10, 7.1};


for (int grade = 0; grade < grades.Count; grade++)
{   

    if (grades[grade] < 5.5)
    {   
        Console.WriteLine($"Grade: {grades[grade]}");
        while (answer.ToLower() != "y" && answer.ToLower() != "n")
        {
            Console.WriteLine("Retake this course? y/n");
            answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                grades[grade] += 1;
            }
            else if (answer.ToLower() == "n")
            {

            }
        }
        //dit zorgt ervoor dat de answer weer leeg word en dat je weer de while loop kunt loopen voor de volgende grade
        answer = "";
    }
}
Console.WriteLine("Final grades:");

// zo loop je door een lijst om de items om de beurt te printen
foreach (double grade in grades)
{
    Console.WriteLine(grade);
}
