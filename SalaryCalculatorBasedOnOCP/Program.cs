using SalaryCalculatorBasedOnOCP;

internal class Program
{
    private static void Main(string[] args)
    {
        var workerList = new List<BaseCalculator> {
        new JuniorDevSalaryCalculator(new WrokerModel { Id = 1, Name = "Noman", Lavel = "Junior", WorkingHours = 8, HourlyRate = 1.5 }),
        new SeniorDevSalaryCalculator(new WrokerModel { Id = 2, Name = "Shihab", Lavel = "Senior", WorkingHours = 8, HourlyRate = 1.5 }),
        new JuniorDevSalaryCalculator(new WrokerModel { Id = 3, Name = "Jidan", Lavel = "Junior", WorkingHours = 8, HourlyRate = 1.5 }),

        };

        var calculator = new SalaryCalculator(workerList);
       double result =  calculator.GetTotalSalary();
        Console.WriteLine(result);
    }
}