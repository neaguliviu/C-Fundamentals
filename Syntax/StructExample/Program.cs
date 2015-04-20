using System;

namespace StructExample
{
    public struct Complex
    {
        public double real, imaginar, modul;

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
            this.real = real;
            this.imaginar = imaginar;
            this.modul = 0;
        }

        public void CalculateAbsoluteValue()
        {
            this.modul = Math.Sqrt(Math.Pow(this.real, 2) + Math.Pow(this.imaginar, 2));
        }

        public override string ToString()
        {
            return String.Format("Numarul complex parte reala = {0} si parte imaginara = {1}", this.real, this.imaginar);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex();
            z.real = 4;
            z.imaginar = 3;
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
            Console.WriteLine("Modulul: {0}", z.modul);
            Console.ReadKey();

            Complex z2 = new Complex(5, 3);
            z2.CalculateAbsoluteValue();
            Console.WriteLine("\n\n---===Struct===---\n");
            Console.WriteLine(z2.ToString());
            Console.WriteLine("Modulul: {0}", z2.modul);
            Console.ReadKey();

        }
    }
}
