Predicate<string> predicate1 = new Predicate<string>(GetBool);
Console.WriteLine(predicate1("admin"));

Predicate<int> predicate2 = (int number) => { return number == 0; };
Console.WriteLine(predicate2(0));

Predicate<int> predicate3 = (number) => number == 1;
Console.WriteLine(predicate3(1));

bool GetBool(string name) => name == "admin";