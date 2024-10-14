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

        public DiscountedItem(string name, double price, int quantity, double discount) : base (name, price, quantity)
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

    public class MainClass
    {
        public static void Main(string[] args)
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
    }
}