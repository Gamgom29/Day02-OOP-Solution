namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Employee Emp = new(1, "Abdelrahman", 3000, Gender.Male);
            //Console.WriteLine(Emp.ToString());
            #endregion

            #region Q02

            #endregion

            #region Q03
            Employee[] Employees = new Employee [3];

            for (int i = 0; i < Employees.Length; i++) 
            {
                Console.WriteLine($"Enter Employee {i+1} Data ");
                Console.WriteLine();
                Console.Write($"Enter Employee {i+1} Id : ");
                int id = int.Parse(Console.ReadLine());

                Console.Write($"Enter Employee {i + 1} Name : ");
                string? Name = Console.ReadLine() ?? "No Name";

                Console.Write($"Enter Employee {i+1} Salary : ");
                decimal Salary  = decimal.Parse(Console.ReadLine()?? "3000");

                Console.Write($"Enter Employee {i+1} Gender (Male - Female) : ");
                Gender Gender = Enum.Parse<Gender>(Console.ReadLine() ?? "Male",true);

                Console.Write($"Enter Employee {i + 1} Hiring Day : ");
                int Day = int.Parse(Console.ReadLine() );

                Console.Write($"Enter Employee {i + 1} Hiring Month : ");
                int Month = int.Parse(Console.ReadLine());

                Console.Write($"Enter Employee {i + 1} Hiring Year : ");
                int Year = int.Parse(Console.ReadLine());

                Console.Write("How Many Privileges Employee Have ? [1-4] : ");
                int cnt = int.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine();
                SecurityLevels Prvivileges = 0;
                if (cnt == 4) Prvivileges = (SecurityLevels)15;
                else
                {
                    if (cnt > 0)
                    {
                        for (int j = 0; j < cnt; j++)
                        {
                            Console.Write("Enter Employee Privilege [Guest  , Developer , Secertary , DBA ] : ");
                            SecurityLevels Prv = Enum.Parse<SecurityLevels>(Console.ReadLine(), true);
                            Prvivileges |= Prv;
                        }

                        Employees[i] = new Employee(id, Name, Salary, Gender, Day, Month, Year, Prvivileges);
                    }
                }
               

                Console.Clear();

            }

            //for (int i = 0; i < Employees.Length; i++) 
            //{
            //    Console.WriteLine($" Employee {i + 1} Data : "); Console.WriteLine();

            //    Console.WriteLine(Employees[i]);

            //    Console.WriteLine();
            //}
            #endregion

            #region Q04

            for (int i = 0; i < Employees.Length; i++)
            {
                for (int j = 0; j < Employees.Length; j++)
                {
                    if (i == j) continue;

                    if(Employees[i].HiringDate.Year > Employees[j].HiringDate.Year)
                            (Employees[i], Employees[j]) = (Employees[j], Employees[i]);
                    
                    else if(Employees[i].HiringDate.Year == Employees[j].HiringDate.Year&& Employees[i].HiringDate.Month > Employees[j].HiringDate.Month)
                            (Employees[i], Employees[j]) = (Employees[j], Employees[i]);

                    else if (Employees[i].HiringDate.Year == Employees[j].HiringDate.Year 
                        && Employees[i].HiringDate.Month  == Employees[j].HiringDate.Month
                        && Employees[i].HiringDate.Day > Employees[j].HiringDate.Day)
                            (Employees[i], Employees[j]) = (Employees[j], Employees[i]);
                }
            }

            foreach (var emp in Employees)
            {
                Console.WriteLine(emp);
                Console.WriteLine();
            }

            // 0 times Boxing and un boxing
            #endregion
        }
    }
}
