using System;

namespace UserNamespace
{
    public abstract class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
            
        }

        public bool verifyLogin(string id, string pass)
        {
            if (this.user_id.Equals(id) && this.user_password.Equals(pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
            Console.WriteLine("Password updated.");
        }

    }

    public class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;
            Console.WriteLine("Admin created.");
        }

        public void updateAdminName(string name)
        {
            this.admin_name = name;
            Console.WriteLine("\nAdmin name updated.");
        }

        public override void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
            Console.WriteLine("\nAdmin password updated.");

        }

        public string getAdmin_name()
        {
            return this.admin_name;
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            
            User admin = new Administrator("Matthew", "id", "pass");
            login((Administrator)admin);


        }

        static void login(Administrator admin)
        {
            while (true)
            {
                Console.WriteLine("\n-- Login --");
                Console.Write("Enter ID       : ");
                string id = Console.ReadLine();
                Console.Write("Enter Password : ");
                string pass = Console.ReadLine();

                if (admin.verifyLogin(id, pass))
                {
                    Console.WriteLine("\nHello, " + admin.getAdmin_name());

                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect credentials.");
                }
            }

            run(admin);
        }

        static void run(Administrator admin)
        {
            while (true)
            {
                Console.WriteLine("\n1. Update admin password.");
                Console.WriteLine("2. Update admin name.");
                Console.WriteLine("3. Log out.");
                Console.Write("Ano gusto mo gawin : ");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Write("\nEnter new password  : ");
                        admin.updatePassword(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("\nEnter new admin name : ");
                        admin.updateAdminName(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("\nLog out na ko man.");
                        login(admin);
                        break;
                    default:
                        Console.WriteLine("Wala namang ganyan e.");
                        break;
                }
            }
        }
       
    }

}