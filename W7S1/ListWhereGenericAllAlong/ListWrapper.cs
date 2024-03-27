
class ListWrapper<T>
{
    private List<T> _mylist;

    public ListWrapper()
    {
        _mylist = new List<T>();
    }

    public void Add(T parameter)
    {
        _mylist.Add(parameter);
    }

    public T Get(int index)
    {
        return _mylist[index];
    }

    public int Count
    {
        get { return _mylist.Count;}
    }
}

