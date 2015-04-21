namespace EnumExample
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Sun = {0}", (int)DaysEnum.Sun);
            Console.WriteLine("Mon = {0}", (int)DaysEnum.Mon);
            Console.WriteLine("Tue = {0}", (int)DaysEnum.Tue);
            Console.WriteLine("Wed = {0}", (int)DaysEnum.Wed);
            Console.WriteLine("Thu = {0}", (int)DaysEnum.Thu);
            Console.WriteLine("Fri = {0}", (int)DaysEnum.Fri);
            Console.WriteLine("Sat = {0}", (int)DaysEnum.Sat);
            Console.ReadKey();
            

            IEnumerable<DaysEnum> list = new List<DaysEnum>() { DaysEnum.Mon, DaysEnum.Tue, DaysEnum.Wed, DaysEnum.Thu, DaysEnum.Fri };


            Console.WriteLine("\n\nWorking days:");
            foreach (DaysEnum day in list)
            {
                Console.WriteLine(Enum.GetName(typeof(DaysEnum), day));
            }
            Console.ReadKey();


            // How to get description attribute:
            Console.WriteLine("\n\nWorking days - enum description:");
            foreach (DaysEnum day in list)
            {
                var dayDescription = EnumHelper.EnumTypeDescription(day);
                Console.WriteLine(dayDescription);
            }
            Console.ReadKey();

        }        
    }
}
