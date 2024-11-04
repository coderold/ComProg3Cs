using System;

namespace StudentNamespace
{
    public class studentInfo
    {
        private string studentID;
        private string firstName;
        private string lastName;

        public studentInfo()
        {
            Console.WriteLine("Student created with no info.");
        }

        public studentInfo(string studentID, string fname, string lname)
        {
            this.studentID = studentID;
            this.firstName = fname;
            this.lastName = lname;

            Console.WriteLine("Student Created.");
        }

        public studentInfo(string fname, string lname)
        {
            this.firstName = fname;
            this.lastName = lname;

            Console.WriteLine("Student created with no id.");
        }


        //getters - setters

        public void setStudentID(string studentID)
        {
            this.studentID = studentID;
        }

        public string getStudentID()
        {
            return studentID;
        }

        public void setFirstname(string fname)
        {
            this.firstName = fname;
        }

        public string getFirstname()
        {
            return firstName;
        }

        public void setLastname(string lname)
        {
            this.lastName = lname;
        }

        public string getLastname()
        {
            return lastName;
        }
    }

    class mainClass
    {
        public static void Main(string[] args)
        {
            studentInfo student1 = new studentInfo("123456", "Nicole", "Angela");
            studentInfo student2 = new studentInfo("Matthew", "Molina");
            studentInfo student3 = new studentInfo();

            Console.WriteLine();

            student2.setStudentID("100101");

            student3.setStudentID("098765");
            student3.setFirstname("Jack");
            student3.setLastname("Roberto");

            Console.WriteLine("\nStudents List: \n");
            printInfo(student1);
            printInfo(student2);
            printInfo(student3);

        }

        static void printInfo(studentInfo student)
        {
            Console.WriteLine("Student ID : " + student.getStudentID());
            Console.WriteLine("First Name : " + student.getFirstname());
            Console.WriteLine("Last Name  : " + student.getLastname() + "\n");
        }

    }
}