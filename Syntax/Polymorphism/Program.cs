using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal duck=new Duck();
            Duck duck2= new Duck();
            Console.WriteLine("duck 1 walking:");
            duck.Walk();
            
            Console.WriteLine("duck 2 walking:");
            duck2.Walk();

            Console.WriteLine("duck 2 eating:");
            duck2.Eat();
            duck2.Eat("pizza");


            Console.WriteLine("duck 3 eating:");
            Animal duck3 = duck2;
            duck3.Eat();

            Console.WriteLine("Cat walking:");
            var cat=new Cat();
            cat.Age = 10;
            cat.Walk();
            Console.WriteLine("Cat's age:");
            Console.WriteLine(cat.Age);
            Console.ReadLine();
        }
    }
}
