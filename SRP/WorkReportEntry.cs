namespace SRP;

public class WorkReportEntry
{
    private string _projectCode;
    private string _projectName;
    private int _spentHours;

    public WorkReportEntry(string projectCode, string projectName, int spentHours)
    {
        _projectCode = projectCode;
        _projectName = projectName;
        _spentHours = spentHours;
    }

    public string ProjectCode { get => _projectCode; }
    public string ProjectName { get => _projectName;  }
    public int SpentHours { get => _spentHours;  }
}
