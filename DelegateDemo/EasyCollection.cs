namespace DelegateDemo;

public delegate void ActionItem(int x);
public delegate int FuncItem(int x);

public class EasyCollection
{
    private readonly List<int> _list;

    public EasyCollection(int size)
    {
        _list = new List<int>();

        var random = new Random();
        for (int i = 0; i < size; i++)
        {
            _list.Add(random.Next(0, 11));
        }
    }

    public IEnumerable<int> GetCollection() => _list;

    public void ForEach(ActionItem action)
    {
        foreach (var item in _list)
        {
            action(item);
        }
    }

    public IEnumerable<int> ForEach(FuncItem func)
    {
        /*var list = new List<int>();
        
        foreach (var i in _list)
        {
            list.Add(func(i));
        }

        return list;*/
        
        foreach (var i in _list)
        {
            yield return func(i);
        }
    }
}