namespace LiskovSubstitution;

public class SumEvenNumber:Calculator
{
    public SumEvenNumber(int[] numbers) :base(numbers)
    {
        
    }

    public override int Calculate()
    {
       return _numbers.Where(x => x % 2 == 0).Sum();
    }
}
