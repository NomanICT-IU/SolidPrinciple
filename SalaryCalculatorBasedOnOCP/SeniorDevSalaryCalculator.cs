namespace SalaryCalculatorBasedOnOCP;

internal class SeniorDevSalaryCalculator : BaseCalculator
{
    public SeniorDevSalaryCalculator(WrokerModel wrokerModel) :base(wrokerModel)
    {
        
    }
    public override double CalculateSalary()
    {
        return base.CalculateSalary() * 3;
    }
}
