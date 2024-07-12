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
                Console.Write($"Enter Employee {i+1} Id ");
                int id = int.Parse(Console.ReadLine());

                Console.Write($"Enter Employee {i + 1} Name ");
                string? Name = Console.ReadLine();

                Console.Write($"Enter Employee {i+1} Salary ");
                decimal Salary  = decimal.Parse(Console.ReadLine()?? "3000");

                Console.Write($"Enter Employee {i+1} Gender (Male - Female) ");
                Gender Gender = Enum.Parse<Gender>(Console.ReadLine() ?? "Male",true);

                Console.Write("How Many Privileges Employee Have ? : ");
                int cnt = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine();
                if (cnt > 0) 
                {
                    SecurityLevels Prvivileges = 0;
                    for (int j = 0; j < cnt; j++)
                    {
                        Console.Write("Enter Employee Privilege [Guest  , Developer , Secertary , DBA ] : ");
                        SecurityLevels Prv = Enum.Parse<SecurityLevels>(Console.ReadLine(), true);
                        Prvivileges |= Prv;
                    }

                    Employees[i] = new Employee (id , Name , Salary , Gender , Prvivileges);
                }
                Console.Clear();

            }
            #endregion

        }
    }
}
