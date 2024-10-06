using DataTypes;

DataTypes.Stack<int> x = new DataTypes.Stack<int>();

x.Push(4);
x.Push(5);
x.Push(8);
x.Push(9);

Console.WriteLine(x.Current);
Console.WriteLine(x.Pop());
Console.WriteLine(x.Current);
Console.WriteLine(x.Pop());
Console.WriteLine(x.Current);