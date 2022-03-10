// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welocome to Employee Wage");

Random random = new Random();   //Generates Random Numbers

const int Present = 1,
            Halfday = 2,
            fullMonth=3,
            Absent = 0,
            Fulltime = 8,
            Partime = 4,
            perHrWage = 20, 
            perMonth =20;

int isPresent = random.Next(4),    // Present = 1, Halfday = 2, fullMonth=3, Absent = 0,
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

    case fullMonth:
        Console.WriteLine("Employee Monthly salary");
        empWage = perMonth * (Fulltime * perHrWage);
        break;

    default:
        Console.WriteLine("Employee is Absent");
        break;

}
 /*       if (isPresent == Present)
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
        }

*/

Console.WriteLine("empWage: " + empWage);