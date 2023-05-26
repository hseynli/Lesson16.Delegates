MyDelegate<int, int> myDelegate1 = new MyDelegate<int, int>(Add);
int i = myDelegate1.Invoke(1);
Console.WriteLine(i);

MyDelegate<string, string> myDelegate2 = new MyDelegate<string, string>(Concatenation);
string s = myDelegate2("Alex");
Console.WriteLine(s);

// Delay.
Console.ReadKey();

int Add(int i)
{
    return ++i;
}

string Concatenation(string s)
{
    return "Hello " + s + "!";
}


// Qaytardığı tip - R
delegate R MyDelegate<T, R>(T t);