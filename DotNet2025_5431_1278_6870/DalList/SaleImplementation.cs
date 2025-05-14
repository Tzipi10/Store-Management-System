using DO;
using DalApi;
using System.Linq;
using System.Reflection;
using Tools;

namespace Dal
{
    internal class SaleImplementation:ISale
    {
        public int Create(Sale item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " start create sale");
            Sale s = item with { SaleCode = DataSource.Config.SaleCode };
            DataSource.Sales.Add(s);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end create sale");
            return s.SaleCode;
        }

        public Sale? Read(int code)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read sale");
            try
            {
                return DataSource.Sales.Single(s => s?.SaleCode == code);
            }
            catch
            {
                throw new DalIdDosentExistException("Read - Error: sale Id doese not exist");
            }
        }

        public void Delete(int code)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " start delete sale");
            Sale? s = Read(code);
            DataSource.Sales.Remove(s);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end delete sale");
        }

        public void Update(Sale item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " start update sale");
            Delete(item.SaleCode);
            DataSource.Sales.Add(item);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end update sale");
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read all with filter sale");
            if (filter == null)
                return new List<Sale?>(DataSource.Sales);
            return DataSource.Sales.Where(filter).ToList();

        }

        public Sale? Read(Func<Sale, bool>? filter)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read with filter sale");
                return DataSource.Sales.First(filter);
            }
            catch
            {
                throw new DalNotFoundException("ERROR: there is not found in Sales");
            }
        }
    }
}
