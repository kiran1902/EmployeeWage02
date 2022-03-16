using EmployeeWage;

<<<<<<< HEAD


//constants
const int Present = 1,
            Halfday = 2,
            fullMonth=3,
            Absent = 0,
            Fulltime = 8,
            Partime = 4,
            perHrWage = 20, 
            perMonthDays =20,
            maxHr=10;

Random random = new Random();   //Generates Random Numbers
int isPresent = random.Next(4);    // Present = 1, Halfday = 2, fullMonth=3, Absent = 0,

int empWage = 0, //variable
    TotalEmpWage = 0,
    WorkingHrs = 0;

Console.WriteLine("isPresent" + isPresent);
while (TotalEmpWage <= maxHr && TotalEmpWage <= perMonthDays)
{
    WorkingHrs++;
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
    TotalEmpWage += empWage;
    Console.WriteLine("Days# : " + TotalEmpWage + "empWage : " + empWage);
}

Console.WriteLine("empWage: " + empWage);
=======
Employewage empwage = new Employewage();
empwage.StartWageClac();
>>>>>>> UC6_EmpWageOOPS
