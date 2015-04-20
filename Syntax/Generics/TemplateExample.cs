using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class TemplateClass<T>
    {
        public void method(T param)
        {
            Console.WriteLine("Parametrul transmis este: {0}\n", param);
        }
    }

    public class GenericMethod<T>
    {
        T field;

        public GenericMethod(T value)
        {
            this.field = value;
        }

        public T method<U, V>(U param1, V param2)
        {
            Console.WriteLine("{0}, {1}", param1.ToString(), param2.ToString());

            return field;
        }
    }


    public class Car {
        public string type { get; set; }
        public double price { get; set; }

        public Car(string type, double price)
        {
            this.type = type;
            this.price = price;
        }

        public override string ToString()
        {
            return string.Format("Car | type: {0} | price: {1}", type, price);
        }
    }

    class TemplateExample
    {
        static void Main(string[] args)
        {
            TemplateClass<double> obiect1 = new TemplateClass<double>();
            obiect1.method(30.44);

            TemplateClass<string> obiect2 = new TemplateClass<string>();
            obiect2.method("un sir de caractere");

            var car = new Car("Audi", 25000);
            TemplateClass<Car> obiect3 = new TemplateClass<Car>();
            obiect3.method(car);

            Console.ReadKey();


            GenericMethod<int> obiect4 = new GenericMethod<int>(100);
            Console.WriteLine("Generic methode result type {0}", obiect4.method<int, double>(39, 38.2).GetType().ToString());

            GenericMethod<Car> obiect5 = new GenericMethod<Car>(car);
            Console.WriteLine("Generic methode result type {0}", obiect5.method<string, double>(car.type, car.price).GetType().ToString());


            Console.ReadKey();
        }
    }
}
