class Animal { }
class Cat : Animal { }

class Program
{
    delegate T MyDelegate<out T>();   // out - Qayıdan nəticə üçün (Covariance).

    public static Cat CatCreator()
    {
        return new Cat();
    }

    static void Main()
    {
        MyDelegate<Cat> delegateCat = new MyDelegate<Cat>(CatCreator);
        MyDelegate<Animal> delegateAnimal = delegateCat;    // Miras almış klasdan base klasa.                      

        Animal animal = delegateAnimal.Invoke();

        Console.WriteLine(animal.GetType().Name);

        // Delay.
        Console.ReadKey();
    }
}