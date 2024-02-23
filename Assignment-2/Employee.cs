using System;

namespace EmployeeClass
{
    //Base class Employee
    class Employee
    {
        //properties
        public string name;
        public int employeeId;
        public double salary;

        //constructor
        public Employee(string name,int employeeId,double salary)
        {
            this.name = name;
            this.employeeId = employeeId;
            this.salary = salary;
        }

        //method to calculate bonus (virtual method)
        public virtual void CalculateBonus()
        {
            double bonus = salary * 0.1;//10% of salary
            Console.WriteLine("The bonus of the Employee is : " + bonus);
        }
    }

    //manager class inherits from employee
    class Manager : Employee
    {
        //additional property
        public string department;

        //constructor
        public Manager(string name,int employeeId,double salary,string department): base(name,employeeId,salary)
        {
            this.department = department;
        }

        //override method to calculate bonus
        public override void CalculateBonus()
        {
            double bonus = salary * 0.15;//15% of salary
            Console.WriteLine("The bonus for the Manager is : " + bonus);

        }
    }

    //developer class inherits from employee

    class Developer : Employee
    {
        //additional property
        public string programmingLanguage;

        public Developer(string name,int employeeId, double salary,string programmingLanguage): base(name,employeeId,salary)
        {
            this.programmingLanguage = programmingLanguage;
        }
        //override method to calculate bonus
        public override void CalculateBonus()
        {
            double bonus = salary * 0.12; //12% of salary
            Console.WriteLine("The bonus for the Developer is : " + bonus);

        }

    }


}

