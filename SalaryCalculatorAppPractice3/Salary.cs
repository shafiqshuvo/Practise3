using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class Salary
    {
        //public string employeeName;
        //public double basicAmount;
        //public double houseRentPercent;
        //public double medicalAllowancePercent;
        public string Name { set; get; }
        public double Basic { set; get; }
        public double Houserent { set; get; }
        public double MedicalAllowance { set; get; }

        public string GetSalary()
        {
            double salary = Basic + (Basic * Houserent / 100) +
                            (Basic * MedicalAllowance / 100);

            string message = Name + " your salary is: " + salary;

            return message;
        }
    }
}
