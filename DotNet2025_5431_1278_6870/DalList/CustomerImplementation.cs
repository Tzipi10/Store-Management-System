using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        public int Create(Customer item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, MethodBase.GetCurrentMethod().Name, "start create customer");
            bool customer = DataSource.Customers.Any(c => c?.Id == item.Id);

            if (customer)
            {
                throw new DalIdAlreadyExistsException("Create - ERROR: customer Id already exists");
            }
         
            DataSource.Customers.Add(item);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, MethodBase.GetCurrentMethod()!.Name, "end create customer");
            return item.Id;
        }
        public Customer? Read(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " read customer");
            try
            {
                return DataSource.Customers.Single(c => c?.Id == id);
            }
            catch
            {
                throw new DalIdDosentExistException("Read - ERROR: customer Id doese not exist");

            }
        }
        public void Delete(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start delete customer");
            Customer? customerToDelete = Read(id);
            DataSource.Customers.Remove(customerToDelete);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end delete customer");
        }
        public void Update(Customer item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start update customer");
            Delete(item.Id);
            DataSource.Customers.Add(item);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end update customer");
        }
        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " readAll with filter - customer");
            if (filter == null)
               return new List<Customer?>(DataSource.Customers);
            return DataSource.Customers.Where(filter).ToList();


        }
        public Customer? Read(Func<Customer, bool>? filter)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " read with filter - customer");
            try
            {
                return DataSource.Customers.First(filter);
            }
            catch
            {
                throw new DalNotFoundException("ERROR: there is not found in customers");
            }
        }
    }
}
