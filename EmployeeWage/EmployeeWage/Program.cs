// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welocome to Employee Wage");

Random random = new Random();   //Generates Random Numbers

const int Present = 1,
            Absent = 0,
            perHrWage=20,
            Fulltime=8;

int isPresent = random.Next(2),
    empWage = 0;
Console.WriteLine("isPresent" + isPresent);

if(isPresent == Present)
{
    Console.WriteLine("Employee is Present");
    empWage = perHrWage * Fulltime;
}
else
{
    Console.WriteLine("Employee is Absent");
}
Console.WriteLine("empWage: " + empWage);
