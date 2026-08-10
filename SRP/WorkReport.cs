namespace SRP;

public class WorkReport:IEntryManager<WorkReportEntry>
{
    private List<WorkReportEntry> _entries;

    public WorkReport()
    {
        _entries = new List<WorkReportEntry>();
    }

    public void AddEntity(WorkReportEntry entity)
    {
        _entries.Add(entity);
    }

    public void RemoveEntryAt(int index)
    {
        _entries.RemoveAt(index);
    }

    public override string ToString() =>
       string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));


}
