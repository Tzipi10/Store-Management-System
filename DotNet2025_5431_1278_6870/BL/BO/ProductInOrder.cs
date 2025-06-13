using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace BO
{
    public class ProductInOrder
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public List<SaleInProduct> Sales { get; set; }
        public double FinalPrice { get; set; }


        public ProductInOrder(int productId, string productName, double price, int quantity)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
            this.Sales = new List<SaleInProduct>();
            this.FinalPrice = 0;
        }
        //public override string ToString() => this.ToStringProperty();

        public override string ToString()
        {
            return "productId: " + ProductId + " ProductName: " + ProductName + " Price: " + Price + " Quantity: " + Quantity + " FinalPrice: " + FinalPrice + " sales: " + Sales.ToString();
        }
    }
}
