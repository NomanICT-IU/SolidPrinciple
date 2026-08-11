namespace SingleResponsiblity;

public class FileServer
{
    public void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> report)
    {
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());

    }
}
