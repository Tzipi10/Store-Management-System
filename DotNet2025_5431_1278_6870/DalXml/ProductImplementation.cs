using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal
{
    [Serializable]

    internal class ProductImplementation : IProduct
    {
        static string file_path = "../xml/products.xml";

        public int Create(Product item)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "Start Create Product");

                List<Product> products = new List<Product>();
                if (File.Exists(file_path))
                {
                    products = Config.LoadFromXml<Product>(file_path);
                    item = item with { ProductCode = Config.NextProductCode };

                    bool Product = products.Any(c => c?.ProductCode == item.ProductCode);

                    if (Product == null)
                    {
                        throw new DalIdAlreadyExistsException("Create - ERROR: Product Id already exists");
                    }

                    products.Add(item);
                    Config.SaveToXml(file_path, products);
                    LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "End Create Product");
                    return item.ProductCode;
                }
                throw new DalIdDosentExistException("this file doesnt exist!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start delete Product");
                if (File.Exists(file_path))
                {
                    List<Product> products = Config.LoadFromXml<Product>(file_path);
                    Product? ProductToDelete = Read(id);
                    products.Remove(ProductToDelete);
                    Config.SaveToXml(file_path, products);
                    LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end delete Product");
                }
                else
                    throw new DalIdDosentExistException("this file doesnt exist!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product? Read(int id)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start read Product");
                List<Product> products = new List<Product>();
                if (File.Exists(file_path))
                {
                    products = Config.LoadFromXml<Product>(file_path);
                    Product findProduct = products.Single(c => c?.ProductCode == id);
                    if (findProduct != null)
                    {
                        return findProduct;
                    }
                    throw new DO.DalIdDosentExistException("Read - ERROR: Product Id not exists");
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product? Read(Func<Product, bool>? filter)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " read with filter - product");
                List<Product> products = Config.LoadFromXml<Product>(file_path);
                return products.First(filter);
            }
            catch (Exception ex)
            {
                throw new DalIdDosentExistException("ERROR: There is no customer that meets the condition : product");
            }
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " readAll with filter Product");
                List<Product> products = Config.LoadFromXml<Product>(file_path);
                if (filter == null)
                    return products;
                return products.Where(filter).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Product item)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start update Product");
                Delete(item.ProductCode);
                List<Product> products = Config.LoadFromXml<Product>(file_path);
                products.Add(item);
                Config.SaveToXml<Product>(file_path, products);
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end update Product");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
