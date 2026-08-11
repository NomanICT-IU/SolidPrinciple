using System.Text;

namespace SingleResponsiblity;

public class WorkerReport : IEntryManager<WorkerReportEntity>
{
    private List<WorkerReportEntity> _entries;
    public WorkerReport()
    {
        _entries = new List<WorkerReportEntity>();
    }

    public void AddEntity(WorkerReportEntity entity)
    {
        _entries.Add(entity);
    }
    public int RemoveEntity(string value)
    {
        return _entries.RemoveAll(x => x.ProjectCode == value);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var x in _entries)
        {
            sb.AppendLine($"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}");
        }
        return sb.ToString().TrimEnd();
    }
}
