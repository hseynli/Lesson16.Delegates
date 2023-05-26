class MyClass
{
    public void Method()
    {
        Console.WriteLine("Deleqat ilə çağrılmış metod.");
    }
}


public delegate void MyDelegate();

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        MyClass instance = new MyClass();

        //Klasın adi (instance) metodunu reference olaraq deleqata ötürürük.
        MyDelegate myDelegate = new MyDelegate(instance.Method); 

        myDelegate.Invoke();

        myDelegate();       

        // Delay.
        Console.ReadKey();
    }
}