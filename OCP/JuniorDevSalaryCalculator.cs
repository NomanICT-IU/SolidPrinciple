using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport)
       : base(developerReport)
        {
        }
        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;

    }
}
