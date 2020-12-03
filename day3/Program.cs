using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main()
        {
            Manager m = new Manager("Nik", 10, 15000, "Software");
            GeneralManager gm = new GeneralManager("Nick", 20, 55000, "logistics", "promoted");
            CEO c = new CEO("Nikk", 30, 95000);

            Console.WriteLine(c.EMPNO + " " + c.NAME + " " + c.DEPTNO + " " + c.BASIC + " " + c.CalcNetSalary());
            Console.WriteLine(m.EMPNO + " " + m.NAME + " " + m.DEPTNO + " " + m.BASIC + " " + m.DESGN + " " + m.CalcNetSalary());
            Console.WriteLine(gm.EMPNO + " " + gm.NAME + " " + gm.DEPTNO + " " + gm.BASIC + " " + gm.DESGN + " " + gm.PERKS + " " + gm.CalcNetSalary());

            Console.ReadLine();
        }
    }
    public abstract class Employee
    {
        private string Name;
        public string NAME
        {
            set
            {
                if (value != "")
                    Name = value;
                else
                    Console.WriteLine("Name canot be blank.");
            }
            get
            {
                return Name;
            }

        }

        private static int count = 0;
        private int EmpNo;
        public int EMPNO
        {
            get
            {
                return EmpNo;
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
                    Console.WriteLine("DeptNo must be > 0");
            }
            get
            {
                return DeptNo;
            }
        }

        protected decimal Basic;
        public abstract decimal CalcNetSalary();

        public Employee(string NAME = "NoName", short DEPTNO = 10)
        {
            count++;
            EmpNo = count;
            this.DEPTNO = DEPTNO;
            this.NAME = NAME;
        }
    }

    class Manager : Employee
    {
        private string Designation;
        public string DESGN
        {
            set
            {
                if (value != "")
                    Designation = value;
                else
                    Console.WriteLine("Designaton cannot be blank.");
            }
            get
            {
                return Designation;
            }

        }

        public decimal BASIC
        {
            set
            {
                if (value >= 10000 && value <= 20000)
                    Basic = value;
                else
                    Console.WriteLine("Invalid salary for Manager");
            }

            get
            {
                return Basic;
            }
        }

        public Manager(string NAME, short DEPTNO, decimal BASIC, string DESGN = "NoDesignation") : base(NAME, DEPTNO)
        {
            this.DESGN = DESGN;
            this.BASIC = BASIC;
        }

        public Manager(string NAME, short DEPTNO) : base(NAME, DEPTNO)
        {

        }

        public override decimal CalcNetSalary()
        {
            return BASIC + (BASIC / 10);
        }
    }


    class GeneralManager : Manager
    {
        private string Perks;
        public string PERKS
        {
            set
            {
                Perks = value;
            }
            get
            {
                return Perks;
            }
        }

        public new decimal BASIC
        {
            set
            {
                if (value >= 41000 && value <= 60000)
                    Basic = value;
                else
                    Console.WriteLine("Invalid salary for General Manager");
            }

            get
            {
                return Basic;
            }
        }
        public GeneralManager(string NAME, short DEPTNO, decimal BASIC, string DESGN, string PERKS = "NoPerks") : base(NAME, DEPTNO)
        {
            this.PERKS = PERKS;
            this.BASIC = BASIC;

        }

        public override decimal CalcNetSalary()
        {
            return BASIC + (BASIC / 10);
        }
    }

    class CEO : Employee
    {

        public decimal BASIC
        {
            set
            {
                if (value >= 61000 && value <= 100000)
                    Basic = value;
                else
                    Console.WriteLine("Invalid salary for CEO");
            }

            get
            {
                return Basic;
            }
        }

        public CEO(string NAME, short DEPTNO, decimal BASIC) : base(NAME, DEPTNO)
        {
            this.BASIC = BASIC;
        }

        public sealed override decimal CalcNetSalary()
        {
            return BASIC + (BASIC / 10);
        }
    }

}

