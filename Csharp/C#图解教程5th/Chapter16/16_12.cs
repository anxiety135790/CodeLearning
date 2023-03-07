interface ILiveBirth // interface for animals that give birth to live young
{
    string BabyCalled();
}

class Animal { } // base class for all animals

class Cat : Animal, ILiveBirth // Cat is a subclass of Animal and implements ILiveBirth
{
    string ILiveBirth.BabyCalled()
    {
        return "Kitten";
    }
}

class Dog : Animal, ILiveBirth // Dog is a subclass of Animal and implements ILiveBirth
{
    string ILiveBirth.BabyCalled()
    {
        return "Puppy";
    }
}

class Bird : Animal, ILiveBirth // Bird is a subclass of Animal and implements ILiveBirth
{
    string ILiveBirth.BabyCalled()
    {
        return "Chick";
    }
}

class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    /// <remarks>
    /// 
    static void Main()
    {
        Animal[] animals = new Animal[3];
        animals[0] = new Cat();
        animals[1] = new Dog();
        animals[2] = new Bird();

        foreach (Animal a in animals)
        {
            ILiveBirth ilb = (ILiveBirth)a; // cast to ILiveBirth
            if (ilb != null)
                Console.WriteLine($"A {ilb.BabyCalled()} is born.");
        }
    }
}