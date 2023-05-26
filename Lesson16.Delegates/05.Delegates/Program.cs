public delegate void MyDelegate();

class Program
{
    // Metodlar.
    public static void Method1()
    {
        Console.WriteLine("Method1");
    }

    public static void Method2()
    {
        Console.WriteLine("Method2");
    }

    public static void Method3()
    {
        Console.WriteLine("Method3");
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        MyDelegate myDelegate = null;
        MyDelegate myDelegate1 = new MyDelegate(Method1);
        MyDelegate myDelegate2 = new MyDelegate(Method2);
        MyDelegate myDelegate3 = new MyDelegate(Method3);

        // Deleqatları kombinasiya edirik.
        myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

        Console.WriteLine("Birdən yeddiyə kimi ədəd daxil edin");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                {
                    myDelegate1.Invoke();
                    break;
                }
            case "2":
                {
                    myDelegate2.Invoke();
                    break;
                }
            case "3":
                {
                    myDelegate3.Invoke();
                    break;
                }
            case "4":
                {
                    MyDelegate myDelegate4 = myDelegate - myDelegate1;
                    myDelegate4.Invoke();
                    break;
                }
            case "5":
                {
                    MyDelegate myDelegate5 = myDelegate - myDelegate2;
                    myDelegate5.Invoke();
                    break;
                }
            case "6":
                {
                    MyDelegate myDelegate6 = myDelegate - myDelegate3;
                    myDelegate6.Invoke();
                    break;
                }
            case "7":
                {
                    myDelegate.Invoke();
                    break;
                }
            default:
                {
                    Console.WriteLine("Siz yolverilməz data daxil etmisiniz.");
                    break;
                }
        }

        // Delay.
        Console.ReadKey();
    }
}