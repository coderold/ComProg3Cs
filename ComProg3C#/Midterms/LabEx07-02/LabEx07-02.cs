using System;
using System.Reflection;

namespace UserAccountNamespace
{
    public abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public virtual double getTotalPrice()
        {
            return total_price = item_price * item_quantity;
        }

        public virtual void setPayment(double amount)
        {
            //overided this method.
        }
    }

    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_discount = (discount * 0.01) * price;
            this.discounted_price = price - this.item_discount;

        }

        public override double getTotalPrice()
        {
            return discounted_price * item_quantity;
        }

        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
        }

        public double getChange()
        {
            return this.change = this.payment_amount - getTotalPrice();
        }
    }

    public abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }

        public virtual bool validateLogin(string uName, string password)
        {
            if (this.user_name.Equals(uName) && this.user_password.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getFullName()
        {
            return this.full_name;
        }

    }

    public class Cashier : UserAccount
    {
        private string department;
        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {
            this.department = department;
        }

        public override bool validateLogin(string uName, string password)
        {
            if (user_name.Equals(uName) && user_password.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getDepartment()
        {
            return this.department;
        }

    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            UserAccount cashier = new Cashier("Matthew Molina", "Finance", "user", "pass");

            
            runLogin((Cashier) cashier);
            


        }

        static void runCashierApp()
        {
            String name;
            int discount, quantity;
            double price;

            Console.WriteLine("Purchase Discounted Item.\n");

            Console.Write("Item     : ");
            name = Console.ReadLine();

            Console.Write("Discount : ");
            discount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Price    : ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantity : ");
            quantity = Convert.ToInt32(Console.ReadLine());

            DiscountedItem item = new DiscountedItem(name, price, quantity, discount);
            item.setPayment(4000);

            Console.WriteLine("\nTotal amount : " + item.getTotalPrice());
            Console.WriteLine("Change       : " + item.getChange());
        }

        static void runLogin(Cashier cashier)
        {
            while (true)
            {
                Console.WriteLine("User Login\n");

                Console.Write("Username : ");
                string uName = Console.ReadLine();
                Console.Write("Password : ");
                string pass = Console.ReadLine();

                if (cashier.validateLogin(uName, pass))
                {
                    Console.WriteLine("\nWelcome " + cashier.getFullName() + " of " + cashier.getDepartment() + "\n");

                    runProgram(cashier);
                }
                else
                {
                    Console.WriteLine("\nInvalid Credentials.\n");
                }
            }
        }

        static void runProgram(Cashier cashier)
        {
            while (true)
            {
                Console.WriteLine("\n1. Open Cashier App.");
                Console.WriteLine("2. Log out.");
                Console.WriteLine("3. Exit.");
                Console.Write("Ano gusto mo gawin : ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    runCashierApp();
                }
                else if (input == 2)
                {
                    runLogin(cashier);
                }
                else if (input == 3)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Wala namang ganyan e.");
                }
            }
        }
    }
}