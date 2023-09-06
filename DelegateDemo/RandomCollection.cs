namespace DelegateDemo;

public class RandomCollection
{
    private readonly List<int> _list;

    public RandomCollection(int size)
    {
        _list = new List<int>();

        var random = new Random();
        for (int i = 0; i < size; i++)
        {
            _list.Add(random.Next(0, 11));
        }
    }

    public IEnumerable<int> GetCollection() => _list;

    public void ForEach(IAction action)
    {
        foreach (var i in _list)
        {
            action.Operation(i);
        }
    }
}