using System.Reflection;
using System.Xml.Linq;
//using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal
{
    [Serializable]
    internal class SaleImplementation : ISale
    {
        static string file_path = "../xml/Sales.xml";

        public int Create(Sale item)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "Start Create Sale");
                XElement salesXml = XElement.Load(file_path);
                Sale s = item with { SaleCode = Config.NextSaleCode };
                XElement e = new XElement("Sale",
                    new XElement("SaleCode", s.SaleCode),
                    new XElement("ProductId", s.ProductId),
                    new XElement("QuantityForSale", s.QuantityForSale),
                    new XElement("SalePrice", s.SalePrice));
                if (s.IsClub != null)
                {
                    e.Add(new XElement("IsClub", s.IsClub));
                }
                if (s.StartSale != null)
                {
                    e.Add(new XElement("StartSale", s.StartSale));
                }
                if (s.EndSale != null)
                {
                    e.Add(new XElement("EndSale", s.EndSale));
                }
                salesXml.Add(e);
                salesXml.Save(file_path);
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "End Create Sale");
                return s.SaleCode;
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
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " start delete sale");
                List<Sale> sales = new List<Sale>();
                if (File.Exists(file_path))
                {
                    sales = Config.LoadFromXml<Sale>(file_path);
                    Sale? SaleToDelete = Read(id);
                    sales.Remove(SaleToDelete!);
                        Config.SaveToXml(file_path, sales);
                        LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end delete sale");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Sale? Read(int id)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read sale");
                List<Sale> sales = new List<Sale>();
                if (File.Exists(file_path))
                {
                    sales = Config.LoadFromXml<Sale>(file_path);
                    Sale findSale = sales.FirstOrDefault(c => c?.SaleCode == id);
                    if (findSale != null)
                    {
                        return findSale;
                    }
                    throw new DO.DalIdDosentExistException("Read - ERROR: Sale Id not exists");
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Sale? Read(Func<Sale, bool>? filter)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read with filter sale");
                List<Sale> sales = new List<Sale>();
                if (File.Exists(file_path))
                {
                    sales = Config.LoadFromXml<Sale>(file_path);
                    Sale findSale = sales.FirstOrDefault(filter);
                    return findSale;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read all with filter sale");
                List<Sale> sales = new List<Sale>();
                if (File.Exists(file_path))
                {
                    sales = Config.LoadFromXml<Sale>(file_path);
                    if (filter == null)
                    {
                        return sales!;
                    }
                    return sales.Where(filter).ToList()!;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Sale item)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " start update sale");
                Delete(item.SaleCode);
                Create(item);
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end update sale");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
