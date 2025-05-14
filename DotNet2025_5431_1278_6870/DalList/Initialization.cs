using DO;
using DalApi;

namespace Dal
{
    public static class Initialization
    {
        private static IDal s_dal;
        private static List<int>productCodes=new List<int>();

        private static void createProducts()
        {
            productCodes.Add(s_dal.Product.Create(new Product(0, "ביסלי", 5.9, 500, Categories.SNACKS)));
            productCodes.Add(s_dal.Product.Create(new Product(0, "במבה", 4.9, 300, Categories.SNACKS)));
            productCodes.Add(s_dal.Product.Create(new Product(0, "שוקולד שוויצרי", 14.9, 400, Categories.CHOCOLATES)));
            productCodes.Add(s_dal.Product.Create(new Product(0, "שוקולד במילוי קרם אגוזים", 14.9, 250, Categories.CHOCOLATES)));
            productCodes.Add(s_dal.Product.Create(new Product(0, "ג'לי תות", 10.8, 40, Categories.JELLYS)));
            productCodes.Add(s_dal.Product.Create(new Product(0, "ג'לי לב", 12.8, 64, Categories.JELLYS)));
            productCodes.Add(s_dal.Product.Create(new Product(0, "קבוקים", 8.9, 60, Categories.SNACKS)));
            productCodes.Add(s_dal.Product.Create(new Product(0, "מענצ'ס", 11.9, 78, Categories.SNACKS)));
            productCodes.Add(s_dal.Product.Create(new Product(0, "יין קברנה", 55.9, 500, Categories.LIQUORS)));
            productCodes.Add(s_dal.Product.Create(new Product(0, "יין לבן", 29.9, 100, Categories.LIQUORS)));
        }

        private static void createCustomers()
        {
           s_dal.Customer.Create(new Customer(1234,"ציפי","רבי עקיבא 30","0583291599"));
           s_dal.Customer.Create(new Customer(5678,"גילי","נתיבות המשפט 88","0504155644"));
           s_dal.Customer.Create(new Customer(1111,"יפי", "נתיבות המשפט 67", "0584186456"));
           s_dal.Customer.Create(new Customer(6586,"שלומי","שלמה המלך 2","089791599"));
        }
        private static void createSales()
        {
           s_dal.Sale.Create(new Sale(0,100,4,4.9,false,DateTime.Now,DateTime.MaxValue));
           s_dal.Sale.Create(new Sale(0,103,6,2,true,DateTime.Today,DateTime.UnixEpoch));
        }

        public static void Initialize()
        {
            s_dal = DalApi.Factory.Get; 
            createCustomers();
            createProducts();
            createSales();
        }
    }
}
