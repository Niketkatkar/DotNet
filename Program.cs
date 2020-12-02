using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee1 o1 = new Employee1();
            Employee1 o2 = new Employee1();
            Employee1 o3 = new Employee1();

            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);

            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o1.EMPNO);

            Console.ReadLine();

            Employee1 o4 = new Employee1("Amol", 123465, 10);
            Console.WriteLine("EmpNo:"+o4.EMPNO + " Name:" + o4.NAME + " BasicSal:" + o4.BASIC + " DeptNo:" + o4.DEPTNO);

            Employee1 o5 = new Employee1("Amol", 123465);
            Console.WriteLine("EmpNo:" +o5.EMPNO + " Name:" + o5.NAME + " BasicSal:" + o5.BASIC);

            Employee1 o6 = new Employee1("Amol");
            Console.WriteLine("EmpNo:" + o6.EMPNO + " Name:" + o6.NAME);

            Employee1 o7 = new Employee1();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
    public class Employee1
    {
        private string Name;
        public string NAME
        {
            set
            {
                if (value != "")
                    Name = value;
                else
                    Console.WriteLine("No blank names allowed.");

            }
            get
            {
                return Name;
            }
        }

        static int count = 0;
        private int EmpNo;
        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
        }

        private decimal Basic;
        public decimal BASIC
        {
            set
            {
                if (20000 <= value && value <= 30000)
                    Basic = value;
                else
                    Console.WriteLine("Basic salary is Not valid.");

            }
            get
            {
                return Basic;
            }
        }

        private short DeptNo;
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("Must be > 0");

            }
            get
            {
                return DeptNo;
            }
        }
        
        public Employee1(string NAME, decimal BASIC, short DEPTNO)
        {
            count++;
            EmpNo = count;
            this.NAME = NAME;
            this.BASIC = BASIC;
            this.DEPTNO = DEPTNO;

        }
        public Employee1(string NAME, decimal BASIC)
        {
            count++;
            EmpNo = count;
            this.NAME = NAME;
            this.BASIC = BASIC;
        }
        public Employee1(string NAME)
        {
            count++;
            EmpNo = count;
            this.NAME = NAME;
        }

        public Employee1()
        {
            count++;
            EmpNo = count;
            
        }
        public decimal GetNetSalary()
        {
            return Basic + (Basic / 10);
        }
    }
}
