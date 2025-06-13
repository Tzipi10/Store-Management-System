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
    internal class CustomerImplementation : ICustomer
    {
        static string file_path = "../xml/customers.xml";

        public int Create(Customer item)
        {
            try {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, MethodBase.GetCurrentMethod().Name, "start create customer");
                if (File.Exists(file_path))
                {
                    List<Customer> customers = Config.LoadFromXml<Customer>(file_path);
                    if (customers.Any(c => c?.Id == item.Id))
                    {
                        throw new DalIdAlreadyExistsException("Create - ERROR: customer Id already exists");
                    }
                    customers.Add(item);
                    Config.SaveToXml(file_path, customers);
                    LogManager.writeToLog(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, MethodBase.GetCurrentMethod()!.Name, "end create customer");
                    return item.Id;
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
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " read customer");
                if (File.Exists(file_path))
                {
                    List<Customer> customers = Config.LoadFromXml<Customer>(file_path);
                    Customer? customerToDelete = Read(id);
                    customers.Remove(customerToDelete!);
                    Config.SaveToXml(file_path, customers);
                    LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "End Delete Customer");
                }
                else
                throw new DalIdDosentExistException("this file doesnt exist!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer? Read(int id)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " read customer");
                if (File.Exists(file_path))
                {
                    List<Customer> customers = Config.LoadFromXml<Customer>(file_path);
                    Customer findCustomer = customers.Single(c => c?.Id == id);
                    if (findCustomer != null)
                    {
                        return findCustomer;
                    }
                    throw new DO.DalIdDosentExistException("Read - ERROR: customer Id not exists");
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer? Read(Func<Customer, bool>? filter)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " read with filter - customer");
                List<Customer> customers = Config.LoadFromXml<Customer>(file_path);
                return customers.First(filter);
            }
            catch (Exception ex)
            {
                throw new DalIdDosentExistException("ERROR: There is no customer that meets the condition : Customer");
            }
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " readAll with filter - customer");
                List<Customer> customers = Config.LoadFromXml<Customer>(file_path);
                if (filter == null)
                    return new List<Customer>(customers)!;
                return customers.Where(filter).ToList()!;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Customer item)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start update customer");
                Delete(item.Id);
                List<Customer> customers = Config.LoadFromXml<Customer>(file_path);
                customers.Add(item);
                Config.SaveToXml<Customer>(file_path, customers);
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end update customer");

            }
            catch (Exception ex) 
            {
                throw ex; 
            }
        }
    }
}
