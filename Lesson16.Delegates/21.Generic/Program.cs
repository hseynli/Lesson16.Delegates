class Animal { }
class Cat : Animal { }

class Program
{
    delegate void MyDelegate<in T>(T a);  // in - arqument üçün.

    public static void CatUser(Animal animal)
    {
        Console.WriteLine(animal.GetType().Name);
    }

    static void Main()
    {
        MyDelegate<Animal> delegateAnimal = new MyDelegate<Animal>(CatUser);
        MyDelegate<Cat> delegateCat = delegateAnimal;    // Base klasdan tərəmiş klasa.

        delegateAnimal(new Animal());
        delegateCat(new Cat());

        //delegateCat(new Animal()); // Mümkün deyil.

        // Delay.
        Console.ReadKey();
    }
}