namespace ConsoleApp4;

public class GenericRepository<T> : IRepository<T> where T : class, IEntity
{
    private List<T> _list = new List<T>();
    public void Add(T item)
    {
        if (GetById(item.Id) == null)
        {
            _list.Add(item);
        }
        else throw new Exception("Already exists");
    }

    public void Remove(T item)
    {
        _list.Remove(item);
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        return _list;
    }

    public T GetById(int id)
    {
        return _list.FirstOrDefault(x => x.Id == id);
    }
}