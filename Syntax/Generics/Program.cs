namespace Generics
{
    using System;

    public class TemplateClass<T>
    {
        public void Method(T param)
        {
            Console.WriteLine("Parametrul transmis este: {0}\n", param);
        }
    }

    public class GenericMethod<T>
    {
        T Field;

        public GenericMethod(T value)
        {
            this.Field = value;
        }

        public T Method<TU, TV>(TU param1, TV param2)
        {
            Console.WriteLine("{0}, {1}", param1.ToString(), param2.ToString());

            return Field;
        }
    }


    public class Car {
        public string Type { get; set; }
        public double Price { get; set; }

        public Car(string type, double price)
        {
            this.Type = type;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("Car | type: {0} | price: {1}", Type, Price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TemplateClass<double> obiect1 = new TemplateClass<double>();
            obiect1.Method(30.44);

            TemplateClass<string> obiect2 = new TemplateClass<string>();
            obiect2.Method("un sir de caractere");

            var car = new Car("Audi", 25000);
            TemplateClass<Car> obiect3 = new TemplateClass<Car>();
            obiect3.Method(car);

            Console.ReadKey();


            GenericMethod<int> obiect4 = new GenericMethod<int>(100);
            Console.WriteLine("Generic methode result type {0}", obiect4.Method<int, double>(39, 38.2).GetType().ToString());

            GenericMethod<Car> obiect5 = new GenericMethod<Car>(car);
            Console.WriteLine("Generic methode result type {0}", obiect5.Method<string, double>(car.Type, car.Price).GetType().ToString());


            Console.ReadKey();
        }
    }
}
