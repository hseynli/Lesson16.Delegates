static class MyClass
{
    public static void Method()
    {
        Console.WriteLine("Deleqat ilə çağrılmış metod.");
    }
}

public delegate void MyDelegate();  // Əgər proqramın giriş nöqtəsi varsa, onda deleqat klas səviyyəsində yaradılmalıdır.

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Klasın statik metodunu reference olaraq deleqata ötürürük.
        MyDelegate myDelegate = new MyDelegate(MyClass.Method);

        myDelegate.Invoke();

        myDelegate();       

        // Delay.
        Console.ReadKey();
    }
}