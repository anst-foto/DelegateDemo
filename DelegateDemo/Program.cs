using DelegateDemo;

var collection = new EasyCollection(10);
PrintCollection(collection.GetCollection());

//collection.ForEach(Console.WriteLine);

/*collection.ForEach((item) =>
{
    item *= 10;
    Console.Write($"{item} ");
});*/
//PrintCollection(collection.GetCollection());

var sum = 0;
collection.ForEach(i => sum += i);
Console.WriteLine($"sum = {sum}");

var newList = collection.ForEach(i => i * 10);
PrintCollection(newList);

var randomCollection = new RandomCollection(5);
PrintCollection(randomCollection.GetCollection());

randomCollection.ForEach(new ActionO());

return;

void PrintCollection(IEnumerable<int> collection)
{
    Console.Write("[ ");
    foreach (var i in collection)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine("]");
}

/*var x = 5;
var y = 10;

var result = Calculator.Add(x, y);
Console.WriteLine($"{x} + {y} = {result}");

result = Calculator.Mul(x, y);
Console.WriteLine($"{x} * {y} = {result}");

result = Calculator.Op(x, y, (int x, int y) => x > y ? y : x);
Console.WriteLine($"min = {result}");

result = Calculator.Op(x, y, Max);
Console.WriteLine($"max = {result}");

return;

int Min(int x, int y) => x > y ? y : x;

int Max(int x, int y) => x > y ? x : y;*/