// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welocome to Employee Wage");

Random random = new Random();   //Generates Random Numbers

const int Present = 1,
            Halfday=2,
            Absent = 0,
            perHrWage=20,
            Fulltime=8,
            Partime=4;

int isPresent = random.Next(3),    // Present = 1, Partime = 2, Absent = 0,
    empWage = 0;
Console.WriteLine("isPresent" + isPresent);

switch (isPresent)
{
    case Present:
        Console.WriteLine("Employee is Present");
        empWage = perHrWage * Fulltime;
        break;

    case Halfday:
        Console.WriteLine("Employee is Present");
        empWage = perHrWage * Partime;
        break;

    default:
        Console.WriteLine("Employee is Absent");
        break;

}
        /*if (isPresent == Present)
        {
            Console.WriteLine("Employee is Present");
            empWage = perHrWage * Fulltime;
        }
        else if (isPresent == Halfday)
        {
            Console.WriteLine("Employee is Present");
            empWage = perHrWage * Partime;
        }
        else
        {
            Console.WriteLine("Employee is Absent");
        }*/


        Console.WriteLine("empWage: " + empWage);