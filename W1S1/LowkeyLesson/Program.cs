

Console.WriteLine("Answer the Following MCQs:");
Console.Write("Which of the following is NOT a valid type in C#?\nA: bool\nB: int\nC: var\nD: string\n");
string UserAnswer = Console.ReadLine();
int Points = 0;
if (UserAnswer.ToUpper() == "C")
{
    Points++;
}


Console.Write("What happens if you execute the following line C#?\nint x = 1.23;\nA: x will be 1.23\nB: x will be 1\nC: x will be 1.0\nD: you will get a compiler error\n");
string UserAnswer1 = Console.ReadLine();
if (UserAnswer1.ToUpper() == "D")
{
    Points++;
}

Console.Write("Consider the following line:\ndouble d = 1.23;\nWhat are TWO ways to convert variable d to an int?\nA: int i = (int)d;\nB: int i = int(d)\nC: int i = 0 + d\nD: int i = Convert.ToInt32(d)\n");
string UserAnswer2 = Console.ReadLine();
Console.Write("");
string UserAnswer3 = Console.ReadLine();

if (UserAnswer2.ToUpper() == "A" && UserAnswer3.ToUpper() == "D" || UserAnswer2 .ToUpper() == "D" && UserAnswer3.ToUpper() == "A")
{
    {
        Points++;
    }
}


if (Points == 3)
{
    Console.WriteLine($"Your first answer:\n{UserAnswer}\nYour second Answer:\n{UserAnswer1}\nYour third answer:\n{UserAnswer2},{UserAnswer3}\nYour score: {Points} out of 3. Well done!");
}
else
{
    Console.WriteLine($"Your first answer:\n{UserAnswer}\nYour second Answer:\n{UserAnswer1}\nYour third answer:\n{UserAnswer2}\nYour score: {Points} out of 3.");

};

