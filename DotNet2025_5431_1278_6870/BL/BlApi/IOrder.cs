using BO;

namespace BlApi;

public interface IOrder
{
    List<SaleInProduct> AddProductToOrder(Order order, int productId, int countInOrder);
    void DeleteProductFromOrder(Order order, int productId);

    void CalcTotalPriceForProduct(ProductInOrder product);

    void CalcTotalPrice(Order order);
    void DoOrder(Order order);
    void SearchSaleForProduct(ProductInOrder product);
}
