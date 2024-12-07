namespace ConsoleApp4;

public class MyStack<T>
{
    private List<T> _stack;
    public MyStack()
    {
        _stack = new List<T>();
    }
    
    public int Count => _stack.Count;

    public T Pop()
    {
        return _stack[_stack.Count - 1];
    }

    public void Push(T item)
    {
        _stack.Add(item);
    }
}