using BlApi;
using BO;

namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public List<SaleInProduct> AddProductToOrder(Order order, int productId, int countInOrder)
        {
            try
            {
                DO.Product? p1 = _dal.Product.Read(productId);
                if (p1 == null)
                {
                    throw new BlDoesNotExistException("Not Found Product!!!");
                }
                if (p1.Quantity - countInOrder < 0)
                {
                    throw new BlOutOfStockException("There is not enough in stock!!!");
                }
                
                BO.ProductInOrder? p2 = order.ProductsInOrder.FirstOrDefault(p => productId == p1.ProductCode);
                ProductInOrder productInOrder;
                if (p2 == null)
                {
                    productInOrder = new ProductInOrder(productId, p1.ConvertDoToBo().ProductName,p1.ConvertDoToBo().Price,countInOrder);
                    order.ProductsInOrder.AddFirst(productInOrder);
                }
                else
                {
                    productInOrder = p2;
                    productInOrder.Quantity += countInOrder;
                }
                SearchSaleForProduct(productInOrder);
                CalcTotalPriceForProduct(productInOrder);
                CalcTotalPrice(order);
                return productInOrder.Sales;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void CalcTotalPrice(Order order)
        {
            order.TotalPrice = order.ProductsInOrder.Select(s => s.FinalPrice).Sum();
        }

        public void CalcTotalPriceForProduct(ProductInOrder product)
        {
            SearchSaleForProduct(product);
            if (product.Sales.Count() == 0)
            {
                product.FinalPrice = product.Price * product.Quantity;
            }
            else
            {
                List<SaleInProduct> currentSales = new List<SaleInProduct>();
                int count = product.Quantity;
                foreach (var sale in product.Sales)
                {
                    if (count == 0)
                    {
                        break;
                    }
                    if (sale.Quantity >= count)
                    {
                        product.FinalPrice += count/sale.Quantity* sale.Price;
                        count -= count%sale.Quantity;
                        currentSales.Add(sale);
                    }
                }
                product.FinalPrice += product.Price * count;
                product.Sales=currentSales;
            }
        }

        public void DoOrder(Order order)
        {
            order.ProductsInOrder.Select(p=> { _dal.Product.Read(p.ProductId)!.ConvertDoToBo().Quantity-=p.Quantity; return 0; }) ;
        }

        public void SearchSaleForProduct(ProductInOrder product)
        {
            product.Sales = _dal.Sale.ReadAll(s => s.ProductId == product.ProductId && s.ConvertDoToBo().isCurrentSale() &&
                                              product.Quantity >= s.QuantityForSale).OrderBy(s => s!.SalePrice / s.QuantityForSale)
                                              .Select(s => new SaleInProduct(s!.SaleCode, s.QuantityForSale, s.SalePrice)).ToList();
        }

    }
}
