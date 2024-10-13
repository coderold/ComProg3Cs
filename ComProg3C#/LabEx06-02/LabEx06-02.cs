using System;

namespace EmployeeNamespace
{
    public class Employee
    {
        private string id;
        private string firstName;
        private string lastName;
        private string position;

        public Employee(string id,string firstName, string lastName, string position)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;

            Console.WriteLine("Employee created.");
        }

        public Employee(string firstName, string lastName, string position)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;

            Console.WriteLine("Employee with no ID is created.");
        }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            Console.WriteLine("Employee with no position and ID is created.");
        }
        public Employee()
        {
            Console.WriteLine("Employee with no info is created.");
        }

        //getters - setters, kapagod po mag type ng boilerplates

        public void setId(string id)
        {
            this.id = id;
        }

        public string getId()
        {
            return id;
        }

        public void setFirstname(string firstName)
        {
            this.firstName = firstName;
        }

        public string getFirstname()
        {
            return firstName;
        }

        public void setLastname(string lastName)
        {
            this.lastName = lastName;
        }

        public string getLastname()
        {
            return lastName;
        }

        public void setPosition(string position)
        {
            this.position = position;
        }

        public string getPosition()
        {
            return position;
        }

    }

    public class MainClass
    {
        public  static void Main(string[] args)
        {
            Employee employee1 = new Employee("123456", "Squidward", "Tentacles", "Cashier");
            Employee employee2 = new Employee("MR.", "Crabs", "Owner");
            Employee employee3 = new Employee("Patrick", "Star");
            Employee employee4 = new Employee();

            Console.WriteLine();

            employee4.setId("098765");
            employee4.setFirstname("Spongebob");
            employee4.setLastname("Dela Cruz");
            employee4.setPosition("Taga Cook");


            Console.WriteLine("Employee List: \n");
            printInfo(employee1);
            printInfo(employee2);
            printInfo(employee3);
            printInfo(employee4);

        }

        static void printInfo(Employee employee)
        {
            Console.WriteLine("ID         : " + employee.getId());
            Console.WriteLine("First Name : " + employee.getFirstname());
            Console.WriteLine("Last Name  : " + employee.getLastname());
            Console.WriteLine("Position   : " + employee.getPosition() + "\n");
        }
    }
}