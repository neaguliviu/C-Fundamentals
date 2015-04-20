using System;

namespace ValueVsReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var referenceInstance = new ReferenceType();
            referenceInstance.Number = 1;
            referenceInstance.String = "one";

            ChangeProperties(referenceInstance);
            Console.WriteLine("reference: {0} {1}", referenceInstance.Number, referenceInstance.String);

            var valueInstance = new ValueType();
            valueInstance.Number = 1;
            valueInstance.String = "one";

            ChangeProperties(valueInstance);
            Console.WriteLine("value: {0} {1}", valueInstance.Number, valueInstance.String);

            Console.ReadKey();
        }

        static void ChangeProperties(ReferenceType instance)
        {
            instance.Number = 29;
            instance.String = "twentynine";

            Console.WriteLine("reference in method: {0} {1}", instance.Number, instance.String);
        }

        static void ChangeProperties(ValueType instance)
        {
            instance.Number = 29;
            instance.String = "twentynine";

            Console.WriteLine("value in method: {0} {1}", instance.Number, instance.String);
        }
    }

    class ReferenceType
    {
        public int Number { get; set; }
        public string String { get; set; }
    }

    struct ValueType
    {
        public int Number { get; set; }
        public string String { get; set; }
    }
}