using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Company
    {
        int totalEmpWage = 0;
        int numOfEmp = 30;

        public int EmpWageCalc()
        {
            for (int i = 0; i < numOfEmp; i++)
            {
                Employewage emp = new Employewage();
                totalEmpWage += emp.StartWageClac();

            }
            return totalEmpWage;
        }
    }

   
}
