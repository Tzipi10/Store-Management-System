using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Dal
{
    static internal class Config
    {
        private static string file = "../xml/data-config.xml";
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
        public static int NextProductCode
        {
            get
            {
                XElement dataXml = XElement.Load(file);
                int currentCode = (int)dataXml.Element("NextProductCode");
                currentCode++;
                dataXml.Element("NextProductCode").SetValue(currentCode.ToString());
                dataXml.Save(file);
                return currentCode;
            }
        }
        public static int NextSaleCode
        {
            get
            {
                XElement dataXml = XElement.Load(file);
                int currentCode = (int)dataXml.Element("NextSaleCode");
                currentCode++;
                dataXml.Element("NextSaleCode").SetValue(currentCode.ToString());
                dataXml.Save(file);
                return currentCode;
            }
        }

    }
}


//        //public static void ExportToXml<T>(List<T> data, string filePath)
//        //{
//        //    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
//        //    using (TextWriter writer = new StreamWriter(filePath))
//        //    {
//        //        serializer.Serialize(writer, data);
//        //    }
//        //}

//        //public static void ExportDatabase()
//        //{
//        //    IDal dal = DalApi.Factory.Get;

//        //    // ייצוא מוצרים
//        //    List<Product> products = dal.Product.ReadAll();
//        //    ExportToXml(products, "Products.xml");

//        //    // ייצוא לקוחות
//        //    List<Customer> customers = dal.Customer.ReadAll();
//        //    ExportToXml(customers, "Customers.xml");

//        //    // ייצוא מכירות
//        //    List<Sale> sales = dal.Sale.ReadAll();
//        //    ExportToXml(sales, "Sales.xml");
//        //}
//    }
//}

