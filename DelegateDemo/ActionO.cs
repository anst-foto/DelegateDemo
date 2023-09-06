namespace DelegateDemo;

public class ActionO : IAction
{
    public void Operation(int x)
    {
        Console.WriteLine(x * 10);
    }
}