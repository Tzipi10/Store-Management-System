using DO;
namespace Dal
{
    internal static class DataSource
    {
        internal static List<Product?> Products = new List<Product?>();
        internal static List<Customer?> Customers = new List<Customer?>();
        internal static List<Sale?> Sales = new List<Sale?>();

        internal static class Config
        {
            internal const int START_CODE_PRODUCT = 100;
            private static int productCode = START_CODE_PRODUCT;

            internal const int START_CODE_SALE = 100;
            private static int saleCode = START_CODE_SALE;
            public static int ProductCode { get { return productCode++; } }
            public static int SaleCode { get { return saleCode++; } }
        }
         
    }
}

