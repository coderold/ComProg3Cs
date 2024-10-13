using System;
using System.Data;

namespace UserNamespace
{
    public class User
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

        public void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }

    }

    public class Administrator : User
    {
        private string admin_name { get; set; }

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;
        }

        public void updateAdminName(string name)
        {
            this.admin_name = name;
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            User usr = new User("admin", "123");

            

        }
    }

}