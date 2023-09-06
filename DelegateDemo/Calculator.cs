namespace DelegateDemo;

public delegate int Operation(int x, int y);

public static class Calculator
{
    public static int Add(int x, int y) => x + y;
    public static int Mul(int x, int y) => x * y;

    public static int Op(int x, int y, Operation op) => op(x, y);
}