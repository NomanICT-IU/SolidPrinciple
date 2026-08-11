namespace SingleResponsiblity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var report = new WorkerReport();
            report.AddEntity(new WorkerReportEntity { ProjectCode = "01", ProjectName = "Listening", SpentHours = 8 });
            report.AddEntity(new WorkerReportEntity { ProjectCode = "02", ProjectName = "Writing", SpentHours = 8 });
            report.AddEntity(new WorkerReportEntity { ProjectCode = "03", ProjectName = "Spoken", SpentHours = 8 });
            report.AddEntity(new WorkerReportEntity { ProjectCode = "04", ProjectName = "abc", SpentHours = 8 });

            //int response = report.RemoveEntity("01");
            //Console.WriteLine(response);

            string records = report.ToString();
            Console.WriteLine(report);
            var server = new FileServer();
            server.SaveToFile(@"Reports", "WorkReport.txt", report);
        }
    }
}
