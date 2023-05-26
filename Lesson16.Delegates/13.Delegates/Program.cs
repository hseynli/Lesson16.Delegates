Console.OutputEncoding = System.Text.Encoding.UTF8;
// MyDelegate myDelegate = new MyDelegate(MyClass.Method);

MyDelegate myDelegate = MyClass.Method; // Deleqatın təyin etmək
myDelegate();

static class MyClass
{
    public static void Method()
    {
        Console.WriteLine("Bu sətri deleqat tərəfindən təyin olunmuş metod ekrana çıxarır.");
    }
}

delegate void MyDelegate();