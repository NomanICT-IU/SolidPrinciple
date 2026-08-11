namespace SalaryCalculatorByOCP;

public abstract class BaseCalculator
{
    public DeveloperReport DeveloperReport { get; set; }
    protected BaseCalculator(DeveloperReport developerReport)
    {
        DeveloperReport = developerReport;
    }
    public abstract double CalculateSalary();
}
