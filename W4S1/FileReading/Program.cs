    
string MyTextFile = @"C:\Users\Sudeg\Downloads\CSchool\MyWork\W4S1\FileReading\MyTextFile.txt";
string fileContents = File.ReadAllText(MyTextFile);
Console.WriteLine(fileContents);
