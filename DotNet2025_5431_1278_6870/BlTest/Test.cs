using BlApi;
using BO;
using Dal;

namespace BlTest;

internal class Test
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

   public static void createOrder()
    {
        //להכניס את סוג הלקוח
        Console.WriteLine("Inser your Id!");
        int Id;
        int.TryParse(Console.ReadLine(), out Id);
        int productId, countToOrder;

        Console.WriteLine("Enter the customer type!");
        Console.WriteLine("To manager press 1\r\nTo the worker press 2\r\nFor the customer press 3");
        int n;
        int.TryParse(Console.ReadLine(), out n);
        CustomerPreference Preference = (CustomerPreference)n;
        Order order = new Order(Preference);
        List<SaleInProduct> sales = new List<SaleInProduct>();

        bool newOrder =true;
        while (newOrder) {
            while (Id != 0)
            {
                Console.WriteLine("Enter product code!");
                int.TryParse(Console.ReadLine(), out productId);
                if (productId == 0) break;
                Console.WriteLine("Enter quantity!");
                int.TryParse(Console.ReadLine(), out countToOrder);
                sales=s_bl.Order.AddProductToOrder(order, productId, countToOrder);
                Console.WriteLine("list sales: "+string.Join(' ',sales));
                //foreach (SaleInProduct sale in sales)
                //{
                //    Console.WriteLine(sale.ToStringProperty());
                //}
                Console.WriteLine("Total price:"+order.TotalPrice);
                Console.WriteLine("To end the order, press 0!");
            }
            Console.WriteLine("To create new order prees 1, to end press 0!");
            int x;
            int.TryParse(Console.ReadLine(), out x);
            if (x == 0)
                newOrder = false;
            Console.WriteLine("Products in the order: " + string.Join(", ", order.ProductsInOrder.Select(p => p.ToString())));

        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("To Initialize: press 1, no: press other");
        int init;
        int.TryParse(Console.ReadLine(), out init);
        if (init == 1)
            Initialization.Initialize();

        createOrder();
    }
}

