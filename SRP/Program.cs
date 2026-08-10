using SRP;
public class Program
{
    private static void Main(string[] args)
    {
        var entity1 = new WorkReportEntry("001", "Spoken", 8);
        var entity2 = new WorkReportEntry("002", "Written", 8);

        var report = new WorkReport();
        report.AddEntity(entity1);
        report.AddEntity(entity2);

        Console.WriteLine(report.ToString());

      


        var scheduleTask1 = new ShecduleTask(1,"ABC",DateTime.Now);
        var scheduleTask2 = new ShecduleTask(2, "ABCD", DateTime.Now);

        var scheduler = new Scheduler();
        scheduler.AddEntity(scheduleTask1);
        scheduler.AddEntity(scheduleTask2);
        Console.WriteLine(scheduler.ToString());

        var server = new FileServer();
        server.SaveToFile(@"Reports", "WorkReport.txt", report);
        server.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);

    }
}

