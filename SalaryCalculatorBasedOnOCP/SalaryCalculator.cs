namespace SalaryCalculatorBasedOnOCP;

public class SalaryCalculator
{
    private readonly IEnumerable<BaseCalculator> _baseCalculators;

    public SalaryCalculator(IEnumerable<BaseCalculator> baseCalculators)
    {
        _baseCalculators = baseCalculators;
    }

    public double GetTotalSalary()
    {
        double totalSalary = 0;
        foreach (var item in _baseCalculators)
        {
            totalSalary += item.CalculateSalary();
        }
        return totalSalary;
    }
}
