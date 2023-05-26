class MyClass
{
    // Deletaq ilə təyin olunacaq metod yaradırıq.
    public string Method(string name)
    {
        return "Hello " + name;
    }
}

public delegate string MyDelegate(string name);  // Deleqat klası yaradırıq. 

class Program
{
    static void Main()
    {
        MyClass instance = new MyClass();

        MyDelegate myDelegate = new MyDelegate(instance.Method);

        // Arqument qəbul edən metodun deleqat ilə təyin olunması.
        string greeting = myDelegate.Invoke("Jeffrey Richter");

        Console.WriteLine(greeting);

        greeting = myDelegate("Grady Booch");

        Console.WriteLine(greeting);

        // Delay.
        Console.ReadKey();
    }
}