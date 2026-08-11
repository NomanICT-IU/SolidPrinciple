using LiskovSubstitution;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        var sumCalculator = new SumCalculator(numbers);
        Console.WriteLine(sumCalculator.Calculate());

        var evenSumCalculator = new SumEvenNumber(numbers);
        Console.WriteLine(evenSumCalculator.Calculate());
    }
}
