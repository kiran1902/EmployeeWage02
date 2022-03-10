// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welocome to Employee Wage");

Random random = new Random();   //Generates Random Numbers

const int Present = 1,
            Absent = 0;

int isPresent = random.Next(2);
Console.WriteLine("isPresent" + isPresent);

if(isPresent == Present)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}
