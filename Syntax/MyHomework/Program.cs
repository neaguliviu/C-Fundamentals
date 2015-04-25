using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? bDate1 = null;
            DateTime? eDate1 = new DateTime(2015, 4, 10, 8, 0, 0);
            Employee E = new Employee("Popescu", "Ion", bDate1, eDate1, 1000, 20);
            E.DisplayInfo();
            DateTime sDate1 = new DateTime(2015, 4, 10, 8, 0, 0);
            E.addNewLeave(sDate1, 10, leaveTypeEnum.med, E);
            DateTime sDate2 = new DateTime(2014, 2, 26, 8, 0, 0);
            E.addNewLeave(sDate2, 3, leaveTypeEnum.hol, E);
            DateTime sDate3 = new DateTime(2015, 2, 10, 8, 0, 0);
            E.addNewLeave(sDate3, 6, leaveTypeEnum.oth, E);
            E.DisplayAllLeaves();
            E.DisplayInfo();

        }
    }
}
