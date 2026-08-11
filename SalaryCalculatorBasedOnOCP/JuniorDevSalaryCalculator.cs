namespace SalaryCalculatorBasedOnOCP;

public class JuniorDevSalaryCalculator : BaseCalculator
{
    public JuniorDevSalaryCalculator(WrokerModel wrokerModel) :base(wrokerModel)
    {
        
    }
    public override double CalculateSalary()
    {
        return base.CalculateSalary() * 2;
    }
}
