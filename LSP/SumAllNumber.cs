namespace LSP;

public class SumAllNumber : Calculator
{
    public SumAllNumber(int[] numbers):base(numbers)
    {
        
    }
    public override int Calculate()
    {
        return _numbers.Sum();
}
}