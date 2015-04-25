using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class Leave
    {
        private DateTime? startingDate { get; set; }
        private int duration { get; set; }
        public leaveTypeEnum leaveType{ get; set; }
        private Employee employee { get; set; }

        public Leave(DateTime startingDate, int duration, leaveTypeEnum leaveType, Employee employee)
        {
            this.startingDate = startingDate;
            this.duration = duration;
            this.leaveType = leaveType;
            employee = new Employee();
        }

        public void displayLeave()
        {
             Console.WriteLine(startingDate.ToString() + " Durata: " + duration + " zile  Motiv: " + EnumHelper.EnumTypeDescription(leaveType) + " " + employee);
             Console.WriteLine();
        }

    }
}
