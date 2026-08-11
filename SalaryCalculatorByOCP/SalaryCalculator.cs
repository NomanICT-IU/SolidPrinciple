namespace SalaryCalculatorByOCP;

public class SalaryCalculator
{

    private IEnumerable<BaseCalculator> _developerCalculation;

    public SalaryCalculator(List<BaseCalculator> developerCalculation)
    {
        _developerCalculation = developerCalculation;
    }

    public double GetTotalSalary()
    {
        double totalSalary = 0;

        foreach (var item in _developerCalculation)
        {
            totalSalary += item.CalculateSalary();
        }
        return totalSalary;
    }
}
