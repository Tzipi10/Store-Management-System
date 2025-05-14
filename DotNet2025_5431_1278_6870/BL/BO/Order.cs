using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public CustomerPreference Preference { get; set; }
        public LinkedList<ProductInOrder> ProductsInOrder { get; set; }
        public double TotalPrice { get; set; }

        public Order(CustomerPreference Preference)
        {
            this.Preference = Preference;
            this.ProductsInOrder =new LinkedList<ProductInOrder>();
            this.TotalPrice = 0;
        }
    }
}
