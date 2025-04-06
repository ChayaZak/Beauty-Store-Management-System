namespace DalApi;
using DO;

/// <summary>
/// ממשק לניהול מבצעים
/// </summary>
public interface ISale
{
    int Create(Sale item);
    Sale? Read(int Id);
    List<Sale?> ReadAll();
    void Update(Sale item);
    void Delete(int id);
}


