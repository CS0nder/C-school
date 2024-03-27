

Console.WriteLine("Amount of money:");
double Money = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("interest:");
double interest = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Over how many years?:");
int year = Convert.ToInt32(Console.ReadLine());

interest = (interest / 100) + 1;
//Schijf 


double totTax =0;

for (int i = 0; i < year; i++)
{  
    Money *= interest;
    double tax = 0;

    if ( Money >= 50000 && Money < 100000)
    {   

        //tax
        
        tax += (Money - 50000) * 0.015;
        totTax += tax;

       
    }
    else if (Money >= 100000)
    {   
        //tax
        
        tax += 50000* 0.015;
        tax += (Money - 100000) * 0.03;
        totTax += tax;
       
    }
    
    Money -= tax;
}

Console.WriteLine($"Balance after {year} years: {Math.Round(Money)}");
Console.WriteLine($"Amount of taxes paid: {Math.Round(totTax)}");
