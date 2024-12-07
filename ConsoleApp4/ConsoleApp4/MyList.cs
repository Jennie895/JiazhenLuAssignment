namespace ConsoleApp4;

public class MyList<T>
{
    private List<T> _list;

    public MyList()
    {
         _list = new List<T>();
    }

    public void Add(T element)
    {
        _list.Add(element);
    }

    public void RemoveByIndex(int index)
    {
        _list.RemoveAt(index);
    }

    public bool Contains(T element)
    {
        return _list.Contains(element);
    }

    public void Clear()
    {
        _list.Clear();
    }

    public void InsertAt(int index, T element)
    {
        _list.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        _list.RemoveAt(index);
    }

    public T Find(int index)
    {
        return _list[index];
    }

    
}