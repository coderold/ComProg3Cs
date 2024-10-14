using System;

namespace ItemNamespace
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
            return 0;
        }

        public virtual void setPayment(double amount)
        {

        }
    }

    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base (name, price, quantity)
        {
            
        }

        public override double getTotalPrice()
        {
            return base.getTotalPrice();
        }

        public override void setPayment(double amount)
        {
            base.setPayment(amount);
        }

        public double getChange()
        {
            return change;
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello setup");
        }
    }
}