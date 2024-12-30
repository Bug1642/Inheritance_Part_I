namespace Exercise
{
    public class Animal
    {
        public virtual string GiveBirth()
        {
            return "I don’t know how";
        }
    }
    public class Mammal : Animal
    {
        public override string GiveBirth()
        {
            return "I give live birth";
        }
    }
    public class Bird : Animal
    {
        public override string GiveBirth()
        {
            return "I lay eggs";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine(animal.GiveBirth());

            Mammal mammal = new Mammal();
            Console.WriteLine(mammal.GiveBirth());

            Bird bird = new Bird();
            Console.WriteLine(bird.GiveBirth());
        }
    }
}