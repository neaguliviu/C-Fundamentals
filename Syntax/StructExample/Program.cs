using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public struct complex
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
            complex z = new complex();
            z.real = 4;
            z.imaginar = 3;
            z.CalculateAbsoluteValue();

            Console.WriteLine("\n\n---===Struct===---\n");
            Console.WriteLine(z.ToString());
            Console.WriteLine("Modulul: {0}", z.modul);
            Console.ReadKey();
        }
    }
}
