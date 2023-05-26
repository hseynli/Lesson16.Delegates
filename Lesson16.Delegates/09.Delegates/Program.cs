MyDelegate myDelegate;

myDelegate = delegate (int x) { return x * 2; }; // Lyambda-metod.

myDelegate = (x) => { return x * 2; };           // Lyambda-operator.

myDelegate = x => x * 2;                         // Lyambda-ifadə.

int result = myDelegate(4);
Console.WriteLine(result);

// Delay.
Console.ReadKey();

public delegate int MyDelegate(int a);