using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    [Flags]
    enum SecurityLevels
    {
        Guest = 1 , Developer = 2 , Secertary = 4 , DBA = 8
    }
    enum Gender
    {
        M = 1 ,Male = 1, F = 2 , Female = 2 
    }
    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityLevels SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateOnly HiringDate { get; set; }
        public Gender Gender { get; set; }

        public Employee(int Id , string Name , decimal Salary , Gender Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
            this.Gender = Gender;
            this.HiringDate = DateOnly.FromDateTime(DateTime.Now);
            this.SecurityLevel |= SecurityLevels.Guest | SecurityLevels.DBA | SecurityLevels.Developer | SecurityLevels.Secertary;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} \nName : {1} \nSalary : {2:c} \nGender : {3} \nHire Date : {4} \nPrivileges : {5}",
                Id , Name , Salary , Gender , HiringDate , SecurityLevel); 
        }
    }
}
