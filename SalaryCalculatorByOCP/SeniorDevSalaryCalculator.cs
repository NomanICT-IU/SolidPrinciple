using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculatorByOCP
{
    public class SeniorDevSalaryCalculator : BaseCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {

        }
        public override double CalculateSalary()
        {
            return DeveloperReport.WorkingHours * DeveloperReport.HourlyRate * 2;
        }
    }
}
