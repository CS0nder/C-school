string MyTextFile= @"C:\Users\Sudeg\Downloads\CSchool\MyWork\W4S1\FileWriting\MyTextFile.txt";
File.WriteAllText(MyTextFile, "Added Line");

Console.WriteLine(MyTextFile);