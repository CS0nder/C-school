

int countGrades = 0;
List<double> StudentGrades = new List<double>{7, 5.5, 3.2, 10, 4.5};
foreach (double grade in StudentGrades)
{   
  
    if (grade >= 5.5)
    {
        countGrades++;
    }
}

Console.WriteLine($"{countGrades} out of {StudentGrades.Count} students passes");