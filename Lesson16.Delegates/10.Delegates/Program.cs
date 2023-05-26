MyDelegate myDelegate;

myDelegate = delegate { Console.WriteLine("Hello 1"); }; // Lyambda-metod.

myDelegate += () => { Console.WriteLine("Hello 2"); };   // Lyambda-operator.

myDelegate += () => Console.WriteLine("Hello 3");        // Lyambda-ifadə.

myDelegate();

public delegate void MyDelegate();