using BLApi;
using BO;
using static BO.Tools;
using DalApi;
namespace BlImplementation
{
    internal class ProductImplementation : BLApi.IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Product item)
        {
            try
            {
                return _dal.Product.Create(item.ConvertBoToDo());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public BO.Product? Read(int id)
        {
            try
            {
                return _dal.Product.Read(id)?.ConvertDoToBo();
            }
            catch (Exception e)
            {
                throw new BlDoesNotExistException(e.Message);
            }
        }
        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                return _dal.Product.Read(p => filter(p.ConvertDoToBo()))?.ConvertDoToBo();
            }
            catch (Exception e)
            {
                throw new BlNotFoundException(e.Message);
            }
        }
        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Product.ReadAll().Select(p => p?.ConvertDoToBo()).ToList();
                return _dal.Product.ReadAll(p => filter!(p.ConvertDoToBo())).Select(p => p?.ConvertDoToBo()).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Update(BO.Product item)
        {
            try
            {
                _dal.Product.Update(item.ConvertBoToDo());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Delete(int id)
        {
            _dal.Product.Delete(id);
        }
        public List<BO.SaleInProduct> GetAllCurrentSales(int productId, BO.CustomerPreference preference)
        {
            try
            {
                return Read(productId)!.Sales.Where(s => s.Preference == preference && _dal.Sale.Read(s.SaleId)!.ConvertDoToBo().isCurrentSale()).Select(s => s).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
