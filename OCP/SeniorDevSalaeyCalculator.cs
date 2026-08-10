using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public class SeniorDevSalaeyCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaeyCalculator(DeveloperReport report)
        : base(report)
        {
        }
        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
    }
}
