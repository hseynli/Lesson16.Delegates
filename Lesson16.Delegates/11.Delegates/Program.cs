Delegate1 delegate1 = new Delegate1(Method1);

Delegate2 delegate2 = delegate1();

delegate2();

// Delay.
Console.ReadKey();


Delegate2 Method1()     // 1.
{
    return new Delegate2(Method2);
}

void Method2()          // 2.
{
    Console.WriteLine("Hello world!");
}

delegate Delegate2 Delegate1();  // 1.
delegate void Delegate2();       // 2.