namespace SalaryCalculatorByOCP;

public class JuniorDevSalaryCalculator : BaseCalculator
{
    public JuniorDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
    {
    }

    public override double CalculateSalary()
    {
        return DeveloperReport.WorkingHours * DeveloperReport.HourlyRate;
    }
}
