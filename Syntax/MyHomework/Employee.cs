using System;
using System.Collections.Generic;

namespace MyHomework
{
    public class Employee: Person
    {
        private DateTime? dateOfEmployment;
        private int salary;
        private int availableDaysOff;
        
        List<Leave> allLeaves = new List<Leave>();

        public Employee(string lastname, string firstname, DateTime? dateOfBirth, DateTime? dateOfEmployment, int salary, int availableDaysOff)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.dateOfBirth = dateOfBirth;
            this.dateOfEmployment = dateOfEmployment;
            this.salary = salary;
            this.availableDaysOff = availableDaysOff;
            
        }

        public Employee()
        {
           
        }

        public void DisplayInfo()
        {
            Console.WriteLine(lastname + " " + firstname + ", salariu: " + salary + ", zile disponibile: " + availableDaysOff);
            Console.WriteLine();
        }

        private void SubstractDays(int noDays)
        {
            this.availableDaysOff -= noDays;
        }

        public void addNewLeave(DateTime sD, int dur, leaveTypeEnum lT, Employee emp)
        {
            if (dur>this.availableDaysOff)
            {
                throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului.");
            }
            SubstractDays(dur);
            Leave newLeave = new Leave(sD, dur, lT, emp); 
            allLeaves.Add(newLeave); 
        }

        public void DisplayAllLeaves()
        {
            foreach (var Leave in allLeaves)
            {
                Leave.displayLeave();
            }
        }
    }

    

}
