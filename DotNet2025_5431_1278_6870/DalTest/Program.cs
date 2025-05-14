using DalApi;
using Dal;
using DO;
using Tools;
using System.Reflection;

namespace DalTest;
internal class Program
{
    public enum NAME_CLASS { Product, Customer, Sale }
    private static readonly IDal s_dal = DalApi.Factory.Get;
    private static void CreateProduct()
    {
        try
        {
            s_dal.Product.Create(CreateOrUpdateProduct());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
        }
    }
    private static void UpdateProduct()
    {
        try
        {
            Console.WriteLine("Insert code product to update");
            int code;
            int.TryParse(Console.ReadLine(), out code);
            s_dal.Product.Update(CreateOrUpdateProduct(code));
        }
        catch (Exception e)
        {
            LogManager.writeToLog(
           MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
            Console.WriteLine(e.Message);
        }
    }
    private static Product CreateOrUpdateProduct(int code = 0)
    {
        Console.WriteLine("Insert product details:");
        Console.WriteLine("productName:");
        string? name = Console.ReadLine();
        Console.WriteLine("price:");
        double price;
        double.TryParse(Console.ReadLine(), out price);  ///
        int quantity;
        int.TryParse(Console.ReadLine(), out quantity);
        Categories category;
        Categories.TryParse(Console.ReadLine(), out category);
        return new Product(code, name!, price, quantity, category);
    }
    private static void CreateSale()
    {
        try
        {
            s_dal.Sale.Create(CreateOrUpdateSale());
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
            Console.WriteLine(e.Message);
        }
    }
    private static void UpdateSale()
    {
        try
        {
            Console.WriteLine("Insert code sale to update");
            int code;
            int.TryParse(Console.ReadLine(), out code);
            s_dal.Sale.Update(CreateOrUpdateSale(code));
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
            Console.WriteLine(e.Message);
        }
    }
    private static Sale CreateOrUpdateSale(int productId = 0)
    {
        Console.WriteLine("Insert sale details:");
        Console.WriteLine("QuantityForSale:");
        int quantityForSale;
        int.TryParse(Console.ReadLine(), out quantityForSale);
        Console.WriteLine("SalePrice:");
        double salePrice;
        double.TryParse(Console.ReadLine(), out salePrice);
        Console.WriteLine("IsClub:");
        bool isClub;
        bool.TryParse(Console.ReadLine(), out isClub);
        Console.WriteLine("StartSale:");
        DateTime startSale;
        DateTime.TryParse(Console.ReadLine(), out startSale);
        Console.WriteLine("EndSale:");
        DateTime endSale;
        DateTime.TryParse(Console.ReadLine(), out endSale);
        return new Sale(0, productId, quantityForSale, salePrice, isClub, startSale, endSale);
    }
    private static void CreateCustomer()
    {
        try
        {
            s_dal.Customer.Create(CreateOrUpdateCustomer());
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
            Console.WriteLine(e.Message);
        }
    }
    private static void UpdateCustomer()
    {
        try
        {
            s_dal.Customer.Update(CreateOrUpdateCustomer());
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
            Console.WriteLine(e.Message);
        }
    }
    private static Customer CreateOrUpdateCustomer()
    {
        Console.WriteLine("Insert customer details:");
        Console.WriteLine("id:");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        Console.WriteLine("customerName:");
        string? name = Console.ReadLine();
        Console.WriteLine("address:");
        string? address = Console.ReadLine();
        Console.WriteLine("phone number:");
        string? phoneNumber = Console.ReadLine();
        return new Customer(id, name!, address, phoneNumber);
    }
    private static void PrintMenu(int select)
    {
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    Crud("Product", s_dal.Product);
                    break;
                case 2:
                    Crud("Customer", s_dal.Customer);
                    break;
                case 3:
                    Crud("Sale", s_dal.Sale);
                    break;
                case 111:
                    LogManager.clearLog();
                    break;
                default:
                    Console.WriteLine("Wrong selection, please select again!");
                    break;
            }
            select = PrintMainMenu();
        }
    }
    private static void ReadAll<T>(ICrud<T> crud)
    {
        try
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
            Console.WriteLine(e.Message);

        }
    }
    private static void Read<T>(ICrud<T> crud)
    {
        try
        {
            Console.WriteLine("insert code to read");
            int code = int.Parse(Console.ReadLine()!);
            Console.WriteLine(crud.Read(code));
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
            Console.WriteLine(e.Message);
        }
    }
    private static void Delete<T>(ICrud<T> crud)
    {
        try
        {
            Console.WriteLine("insert a code:");
            int code = int.Parse(Console.ReadLine()!);
            crud.Delete(code);
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
            Console.WriteLine(e.Message);
        }
    }
    private static int PrintMainMenu()
    {
        Console.WriteLine("For Product press 1");
        Console.WriteLine("For Customer press 2");
        Console.WriteLine("For Sale press 3");
        Console.WriteLine("for clean log prese 111");
        Console.WriteLine("To exit press 0");
        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            return -1;
        return select;
    }
    private static int PrintSubMenu(string item)
    {
        Console.WriteLine($"To add {item}press 1");
        Console.WriteLine($"To read one {item} press 2");
        Console.WriteLine($"To read all {item} press 3");
        Console.WriteLine($"To update {item} press 4");
        Console.WriteLine($"To delete {item} press 5");
        Console.WriteLine($"To go back press 0");

        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }
    private static void Crud<T>(string item, ICrud<T> crud)
    {
        int select = PrintSubMenu(item);
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    switch (item)
                    {
                        case "Customer":
                            CreateCustomer();
                            break;
                        case "Product":
                            CreateProduct();
                            break;
                        case "Sale":
                            CreateSale();
                            break;
                    }
                    break;
                case 2:
                    Read(crud);
                    break;
                case 3:
                    ReadAll(crud);
                    break;
                case 4:
                    switch (item)
                    {
                        case "Customer":
                            UpdateCustomer();
                            break;
                        case "Product":
                            UpdateProduct();
                            break;
                        case "Sale":
                            UpdateSale();
                            break;
                    }
                    break;
                case 5:
                    Delete(crud);
                    break;
                default:
                    Console.WriteLine("Wrong selection, please select again!");
                    break;
            }
            select = PrintSubMenu(item);
        }

    }
    public static string getCurrentDir()
    {
        return "C:\\Users\\huser\\Desktop\\a";
    }
    public static string getCurrentFile()
    {
        return $@"{getCurrentDir()}\{DateTime.Now.Month}\{DateTime.Now.Day}.txt";
    }

    public static void writeToLog(string projectName, string funcName, string message)
    {
        String directoryPath = $@"{getCurrentDir()}\{DateTime.Now.Month}";
        String currentFile = getCurrentFile();
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        if (!File.Exists(currentFile))
        {
            File.Create(currentFile).Close();
        }
        using (StreamWriter writeText = new StreamWriter(currentFile, true))
        {
            writeText.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{message}");
        }
    }
    static void Main(string[] args)
    {
        try
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start Initialization");
            Initialization.Initialize();
            PrintMenu(PrintMainMenu());
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
            Console.WriteLine(e.Message);
        }
    }
}

