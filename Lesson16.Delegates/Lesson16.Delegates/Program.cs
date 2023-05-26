Console.OutputEncoding = System.Text.Encoding.UTF8;

MyDelegate myDelegate = new MyDelegate(Method); // deleqatın instance-nı yaradırıq.

myDelegate.Invoke(); // deleqat ilə təyin olunmuş metodu çağırırıq.

myDelegate();        // metodu çağırmağın digər yolu.


void Method()
{
    Console.WriteLine("Deleqat ilə çağrılmış metod.");
}

public delegate void MyDelegate();