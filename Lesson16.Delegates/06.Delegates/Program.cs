// Klas-deleqatın instance-nı yaradırıq və onu anonim metodla təyin edirik.
MyDelegate myDelegate = delegate { Console.WriteLine("Hello world!"); };

// Deleqat ilə təyin olunmuş anonim metodun çağrılması.
myDelegate();


// Klas-Deleqatın yaradılması
public delegate void MyDelegate();