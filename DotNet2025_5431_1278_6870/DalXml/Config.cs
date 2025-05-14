using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal
{
    internal static class Config
    {
        private static string File = "data-config";

        public static int NextProductCode {
            get
            {
                XElement DataXml = XElement.Load(File);
                int currentCode = int.Parse(DataXml.Attribute("NextProductCode")!.Value);
                DataXml.Attribute("NextProductCode")!.Value = (currentCode++).ToString();
                DataXml.Save(File);
                return currentCode;
            }
        }

        public static int NextSaleCode
        {
            get
            {
                XElement DataXml = XElement.Load(File);
                int currentCode = int.Parse(DataXml.Attribute("NextSaleCode")!.Value);
                DataXml.Attribute("NextSaleCode")!.Value = (currentCode++).ToString();
                DataXml.Save(File);
                return currentCode;
            }
        }

        private static string file = "data-config";

        public static List<T> LoadFromXml<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (List<T>)serializer.Deserialize(fileStream);
            }
        }

        public static void SaveToXml<T>(string filePath, List<T> items)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, items);
            }
        }
        //public static void ExportToXml<T>(List<T> data, string filePath)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
        //    using (TextWriter writer = new StreamWriter(filePath))
        //    {
        //        serializer.Serialize(writer, data);
        //    }
        //}

        //public static void ExportDatabase()
        //{
        //    IDal dal = DalApi.Factory.Get;

        //    // ייצוא מוצרים
        //    List<Product> products = dal.Product.ReadAll();
        //    ExportToXml(products, "Products.xml");

        //    // ייצוא לקוחות
        //    List<Customer> customers = dal.Customer.ReadAll();
        //    ExportToXml(customers, "Customers.xml");

        //    // ייצוא מכירות
        //    List<Sale> sales = dal.Sale.ReadAll();
        //    ExportToXml(sales, "Sales.xml");
        //}
    }
}
