using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class customer
    {
        public int id;
        public string name;
        public readonly List<Order> Orders =new List<Order>();

        // Constructor
        public customer()
        {
            
        }
        public customer(int id):this()
        {
            this.id=id;
        }
        public customer(int id, string name) :this(id)
        {
            this.name=name;
        }

        public void promote()
        {
            //Orders=new List<Order>();// This caused loss of previous data. So we readonly and remove it from here because
            //readonly field cannot be assigned to
            //(except in a constructor or init - only setter of the type in which the field is defined or a variable initializer
        }

    }
    public class Order
        {

        }
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer=new customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.promote(); // This call removes our data as here, List is initialized again this causes loss of previous data.
                                // That's why we use readonly so that our previous data is not lost. 

            Console.WriteLine(customer.Orders.Count);
            Console.ReadLine();
        }
    }
}
