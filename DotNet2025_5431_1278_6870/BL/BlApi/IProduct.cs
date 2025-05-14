using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BLApi
{ 
    public interface IProduct
    {
        public int Create(Product item); //Creates new entity object in DAL => Return id 
        public Product? Read(int id); //Reads entity object by this ID => Return Object by id 
        public Product? Read(Func<Product, bool> filter);  //Reads entity object function filter => Return Object
        public List<Product?> ReadAll(Func<Product, bool>? filter = null); //stage 1 only, Reads all entity objects => Return a list of all the Objects
        public void Update(Product item); //Updates entity object
        public void Delete(int id); //Deletes an object by this Id
        public List<SaleInProduct> GetAllCurrentSales(int productId, CustomerPreference preference); //return a list with all the current sales
    }
}
