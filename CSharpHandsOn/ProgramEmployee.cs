using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    public interface MyInterface { };
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public new string FirstName = "FN_PTE";
        public new string LastName = "LN_PTE";

        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - PartTimeEmployee");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - FullTimeEmployee");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public int PrintFullName() 
        {
            Console.WriteLine(FirstName + " " + LastName + " - TemporaryEmployee");
            return 1;
        }

        public void MyTempE()
        {
            Console.WriteLine("Exlusive MyFTE method of the FullTimeEmployee class");
        }
    }
    class ProgramEmployee
    {
        public static void Main1()
        {
            #region Test
            //Employee[] employees = new Employee[4];
            //employees[0] = new Employee();
            //employees[1] = new PartTimeEmployee();
            //employees[2] = new FullTimeEmployee();
            //employees[3] = new TemporaryEmployee();

            //foreach (Employee e in employees)
            //{
            //    e.PrintFullName();
            //}

            //employees[0].MyFTE();
            //employees[2].MyFTE();
            //Console.WriteLine(employees[0].FirstName);
            //Console.WriteLine(employees[1].FirstName);
            //Console.WriteLine(new PartTimeEmployee().FirstName);
            #endregion           
            Employee e = new Employee();
            Employee e1 = new TemporaryEmployee();
            TemporaryEmployee tempEmp = new TemporaryEmployee();

            e.PrintFullName();
            e1.PrintFullName();
            tempEmp.PrintFullName();
            //e1.MyTempE();

            Console.ReadLine();
        }
        
    }
}
