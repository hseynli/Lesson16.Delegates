MyDelegate my = null; // Mütləq ilkin olaraq null mənimsətmək lazımdır.

my = (int i) =>
{
    i--;
    Console.WriteLine("Begin {0}", i);

    if (i > 0)
    {
        my(i);
    }

    Console.WriteLine("End {0}", i);
};

my(3);

// Delay.
Console.ReadKey();


delegate void MyDelegate(int argument);