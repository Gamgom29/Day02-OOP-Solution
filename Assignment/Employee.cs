using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    [Flags]
    enum SecurityLevels:byte
    {
        Guest = 1 , Developer = 2 , Secertary = 4 , DBA = 8
    }
    enum Gender:byte
    {
        M = 1 ,Male = 1, F = 2 , Female = 2 
    }
    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityLevels SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HiringDate { get; set; }
        public Gender Gender { get; set; }

        // Full Privileges Ctor
        public Employee(int Id, string Name, decimal Salary, Gender Gender):this(Id, Name, Salary, Gender,(SecurityLevels) 15)
        {
            
        }

        // Full Constructor
        public Employee(int Id , string Name , decimal Salary , Gender Gender , SecurityLevels Privileges)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
            this.Gender = Gender;
            this.HiringDate = new HiringDate(DateTime.Now.Day , DateTime.Now.Month , DateTime.Now.Year);
            this.SecurityLevel = Privileges;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} \nName : {1} \nSalary : {2:c} \nGender : {3} \nHire Date : {4} \nPrivileges : {5}",
                Id , Name , Salary , Gender , HiringDate , SecurityLevel); 
        }
    }
}
