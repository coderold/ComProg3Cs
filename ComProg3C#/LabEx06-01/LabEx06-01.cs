using System;

namespace StudentNamespace
{
    public class studentInfo
    {
        private string studentID;
        private string fname;
        private string lname;

        public studentInfo()
        {
            Console.WriteLine("Student Created With no info");
        }

        public studentInfo(string studentID, string fname, string lname)
        {
            this.studentID = studentID;
            this.fname = fname;
            this.lname = lname;

            Console.WriteLine("Student Created");
        }

        public studentInfo(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;

            Console.WriteLine("Student Created with no id");
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

        public void setFname(string fname)
        {
            this.fname = fname;
        }

        public string getFname()
        {
            return fname;
        }

        public void setLname(string lname)
        {
            this.lname = lname;
        }

        public string getLname()
        {
            return lname;
        }
    }

    class mainClass
    {
        public static void Main(string[] args)
        {

            studentInfo student1 = new studentInfo("Matthew", "Molina");
            studentInfo student2 = new studentInfo("123456", "Nicole", "Angela");
            studentInfo student3 = new studentInfo();

            Console.WriteLine();

            student1.setStudentID("100101");

            student3.setStudentID("098765");
            student3.setFname("Tite");
            student3.setLname("Burat");

            Console.WriteLine("Name : " + student1.getFname() + " " + student1.getLname());
            Console.WriteLine("Id   : " + student1.getStudentID());

            Console.WriteLine("Name : " + student2.getFname() + " " + student2.getLname());
            Console.WriteLine("Id   : " + student2.getStudentID());

            Console.WriteLine("Name : " + student3.getFname() + " " + student3.getLname());
            Console.WriteLine("Id   : " + student3.getStudentID());



        }
    }
}