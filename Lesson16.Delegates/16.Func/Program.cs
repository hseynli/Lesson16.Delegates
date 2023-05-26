Func<int, int> func1 = new Func<int, int>(GetInt);
Console.WriteLine(func1.Invoke(2));

Func<int, int, int> func2 = (int x, int y) => x + y;
Console.WriteLine(func2(2, 5));

Func<int, int, int> func3 = (x, y) => x + y;
Console.WriteLine(func3(5, 6));

int GetInt(int number) => number * 2;