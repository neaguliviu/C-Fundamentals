using System;

namespace StructExample
{
    public struct Complex
    {
        public double Real, Imaginar, Modul;

        /* 
         * Wrong:
         * 
            public complex()
            {
                this.real = 0;
                this.imaginar = 0;
                this.modul = 0;
            }
         * 
         * Structs cannot contain explicit parameterless constructors. Struct members are automatically initialized to their default values.
         * Struct does not support inheritance
         * Struct cannot be abstract. It is default sealed.
         */

        /*
         * Wrong:
         * 
            protected double CalculeazaModul()
            {
                return Math.Sqrt(Math.Pow(this.real, 2) + Math.Pow(this.imaginar, 2));
            }
         * 
         * Struct members cannot be declared as protected because structs do not support inheritance.
         */

        public Complex(double real, double imaginar)
        {
            this.Real = real;
            this.Imaginar = imaginar;
            this.Modul = 0;
        }

        public void CalculateAbsoluteValue()
        {
            this.Modul = Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Imaginar, 2));
        }

        public override string ToString()
        {
            return String.Format("Numarul complex parte reala = {0} si parte imaginara = {1}", this.Real, this.Imaginar);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var z = new Complex();
            z.Real = 4;
            z.Imaginar = 3;
            z.CalculateAbsoluteValue();

            // ... or:
            /*
                Complex z = new Complex
                {
                    real = 4,
                    imaginar = 3
                };
                z.CalculateAbsoluteValue();
            */

            Console.WriteLine("\n\n---===Struct===---\n");
            Console.WriteLine(z.ToString());
            Console.WriteLine("Modulul: {0}", z.Modul);
            Console.ReadKey();

            var z2 = new Complex(5, 3);
            z2.CalculateAbsoluteValue();
            Console.WriteLine("\n\n---===Struct===---\n");
            Console.WriteLine(z2.ToString());
            Console.WriteLine("Modulul: {0}", z2.Modul);
            Console.ReadKey();

        }
    }
}
