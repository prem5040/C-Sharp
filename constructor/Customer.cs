
using System.Collections.Generic;

namespace constructor
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List <Order> Orders;

        public Customer()  //1st Constructor
        {
            Orders = new List<Order>();
        }

        //Here, this() keyword will help to call the default constructor with no parameter at first, then this constructor will be called. 
        public Customer(int id) :this()  //2nd Constructor
        {
            this.Id = id;

        }

/*        Here, this() keyword will call COnstructor 2nd which will call 1st constructor where:
 *        In 1st constructor, Order will be initialized.
 *        in 2nd Constructor, id will be iniialized.
 *        In 3rd constructor, name will  be initialized
 *        
 */        
        public Customer(int id, string name) :this(id)  //3rd Constructor
        {
            //this.Id = id; // Since, id will be initialized in 2nd constructor, we can remove from here.
            this.Name = name;

        }
    }

}