using SalaryCalculatorByOCP;

public class Program
{
    private static void Main(string[] args)
    {
        var devReports = new List<BaseCalculator>
        {
            new JuniorDevSalaryCalculator(new DeveloperReport { Id = 1,Name ="Noman",Level = "Junior",WorkingHours = 8, HourlyRate = 1.2 } ),
            new JuniorDevSalaryCalculator(new DeveloperReport { Id = 2,Name ="Ashik",Level = "Junior",WorkingHours = 8, HourlyRate = 1.2 }),
            new SeniorDevSalaryCalculator(new DeveloperReport { Id = 3,Name ="Showon",Level = "Senior",WorkingHours = 8, HourlyRate = 1.2 }),

        };

        var calculator = new SalaryCalculator(devReports);

       var result = calculator.GetTotalSalary();

        Console.WriteLine(result);
    }
}