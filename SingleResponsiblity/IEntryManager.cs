namespace SingleResponsiblity;

public interface IEntryManager<T>
{
    public void AddEntity(T entity);
    public int RemoveEntity(string value);
}
