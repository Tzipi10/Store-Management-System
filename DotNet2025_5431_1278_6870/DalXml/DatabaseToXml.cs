using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal;
public static class DatabaseToXml
{
    public static void ExportToXml<T>(List<T> data, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
        using (TextWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, data);
        }
    }

    public static void ExportDatabase()
    {
        IDal dal = DalApi.Factory.Get;

        // ייצוא מוצרים
        List<Product> products = dal.Product.ReadAll();
        ExportToXml(products, "Products.xml");

        // ייצוא לקוחות
        List<Customer> customers = dal.Customer.ReadAll();
        ExportToXml(customers, "Customers.xml");

        // ייצוא מכירות
        List<Sale> sales = dal.Sale.ReadAll();
        ExportToXml(sales, "Sales.xml");
    }
}
