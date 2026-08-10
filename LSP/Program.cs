using System;
using LSP;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
        var sumNumber = new SumAllNumber(numbers);
        int sumAllNumber = sumNumber.Calculate();

        Console.WriteLine(sumAllNumber);

        var sumEveneNumber = new EvenCalculator(numbers);
        int sumationOfEnvenNumber = sumEveneNumber.Calculate();

        Console.WriteLine(sumationOfEnvenNumber);
    }
}