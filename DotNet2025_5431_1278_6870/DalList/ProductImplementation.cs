using DO;
using DalApi;
using System.Linq;
using System.Reflection;
using Tools;

namespace Dal
{
    internal class ProductImplementation:IProduct
    {
        public int Create(Product item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "Start Create Product");

            Product product = item with { ProductCode = DataSource.Config.ProductCode };
            DataSource.Products.Add(product);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "End Create Product");
            return product.ProductCode;
        }

        public Product? Read(int id)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start read Product");
                return DataSource.Products.Single(p => p?.ProductCode == id);
            }
            catch
            {
                throw new DalIdDosentExistException("Read - ERROR: product Id doese not exist");
            }
        }

        public void Delete(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start delete Product");
            DataSource.Products.Remove(Read(id));
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end delete Product");
        }

        public void Update(Product item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start update Product");
            Delete(item.ProductCode);
            DataSource.Products.Add(item);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end update Product");
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " readAll with filter Product");
            if (filter == null)
                return new List<Product?>(DataSource.Products);
            return DataSource.Products.Where(filter).ToList();

        }

        public Product? Read(Func<Product, bool>? filter)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read Product");
                return DataSource.Products.First(filter);
            }
            catch
            {
                throw new DalNotFoundException("ERROR: there is not found in Products");
            }
        }
    }
}
