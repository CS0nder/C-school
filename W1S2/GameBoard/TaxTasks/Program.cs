
/*
Console.WriteLine("Amount of money:");
double Money = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("interest:");
double interest = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Over how many years?:");
int year = Convert.ToInt32(Console.ReadLine());

interest = (interest / 100) + 1;
//Schijf 

double tax = 0;
double totTax =0;

for (int i = 0; i < year; i++)
{   
    double tax1 = 0;
    double tax2 = 0;
    Money = Money * interest;

    if ( Money >= 50000 && Money < 100000)
    {   

        //tax
        double MoneyS2 = Money - 49999;
        tax1 = MoneyS2 * 0.015;
        totTax += tax1;

       
    }
    else if (Money >= 100000)
    {   
        //tax
        double MoneyS3 = Money - 99999;
        tax2 = MoneyS3 * 0.03;
        totTax += tax2;
       
    }
    
    Money = Money - tax1 - tax2;
}

Console.WriteLine($"Balance after {year} years: {Math.Round(Money)}");
Console.WriteLine($"Amount of taxes paid: {Math.Round(totTax)}");



*/

Console.WriteLine("Amount of money:");
double Money = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("interest:");
double interest = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Over how many years?:");
int year = Convert.ToInt32(Console.ReadLine());

interest = (interest / 100) + 1;
//Schijf 

double tax = 0;
double totTax =0;

for (int i = 0; i < year; i++)
{   
    double tax1 = 0;
    double tax2 = 0;
    Money = Money * interest;
    double MoneyS2 = Money - 49999;
    double MoneyS3 = Money - 99999;
    if ( Money >= 50000 && Money < 100000)
    {   

        //tax
        MoneyS2 = Money - 49999;
        tax1 = MoneyS2 * 0.015;
        totTax += tax1;

       
    }
    else if (Money >= 100000)
    {   
        //tax
        
        tax1 = MoneyS2 * 0.015;
       
        tax2 = MoneyS3 * 0.03;
        totTax += tax1 + tax2;
       
    }
    
    Money = Money - tax1 - tax2;
}

Console.WriteLine($"Balance after {year} years: {Math.Round(Money)}");
Console.WriteLine($"Amount of taxes paid: {Math.Round(totTax)}");
