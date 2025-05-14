using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using System.Xml.Serialization;

namespace BO
{
    internal static class Tools
    {
        public static string ToStringProperty<T>(this T s, string prefix = "")
        {
            StringBuilder sb = new StringBuilder();
            Type t = s?.GetType() ?? throw new Exception("s is NULL");
            foreach (PropertyInfo prop in t.GetProperties())
            {
                if (prop.PropertyType.IsPrimitive
                    || prop.PropertyType == typeof(string)
                    || prop.PropertyType == typeof(DateTime))
                    sb.AppendLine($"{prefix}{prop.Name} = {prop.GetValue(s)}");
                else
                    sb.Append($"{prefix}{prop.Name} =\n{prop.GetValue(s).ToStringProperty(prefix + "\t")}");
            }
            return sb.ToString();
        }
        public static bool isCurrentSale(this Sale s)
        {
            if (s.StartSale == null) return false;
            return s.StartSale <= DateTime.Now && s.EndSale >= DateTime.Now;
        }
        public static BO.Customer ConvertDoToBo(this DO.Customer c)
        {
            try
            {
                return new BO.Customer(c.Id, c.Name, c.Address, c.PhoneNumber);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static DO.Customer ConvertBoToDo(this BO.Customer c)
        {
            try
            {
                return new DO.Customer(c.Id, c.Name, c.Address, c.PhoneNumber);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static BO.Sale ConvertDoToBo(this DO.Sale s)
        {
            try
            {
                return new BO.Sale(s.SaleCode, s.ProductId, s.QuantityForSale, s.SalePrice, s.IsClub, s.StartSale, s.EndSale);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static DO.Sale ConvertBoToDo(this BO.Sale s)
        {
            try
            {
                return new DO.Sale(s.SaleCode, s.ProductId, s.QuantityForSale, s.SalePrice, s.IsClub, s.StartSale, s.EndSale);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static BO.Product ConvertDoToBo(this DO.Product p)
        {
            try
            {
                return new BO.Product(p.ProductCode, p.ProductName, p.Price, p.Quantity, (BO.Categories?)p.Category);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static DO.Product ConvertBoToDo(this BO.Product p)
        {
            try
            {
                return new DO.Product(p.ProductCode, p.ProductName, p.Price, p.Quantity, (DO.Categories?)p.Category);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
