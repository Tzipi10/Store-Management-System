
using BlApi;
using BO;
using DO;
using static BO.Tools;

namespace BlImplementation
{
    internal class CustomerImplementation : ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Customer item)
        {
            try
            {  
                return _dal.Customer.Create(item.ConvertBoToDo());
            }
            catch (DO.DalIdDosentExistException ex)
            {
                throw new BlIdAlreadyExistsException(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch (DalNotFoundException ex)
            {
                throw new BlNotFoundException(ex.Message);
            }
        }

        public bool IsExist(int id)
        {
            try
            {
                DO.Customer? customer = _dal.Customer.Read(id);
                if (customer == null) 
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public BO.Customer? Read(int id)
        {
            try
            {
                DO.Customer? customer = _dal.Customer.Read(id);
                return customer?.ConvertDoToBo();
            }
            catch (Exception ex)
            {
                throw new BlDoesNotExistException(ex.Message);
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool>? filter)
        {
            try
            {
                return _dal.Customer?.Read(doCustomer => filter!(doCustomer.ConvertDoToBo()))?.ConvertDoToBo();
            }
            catch (Exception ex)
            {
                throw new BlNotFoundException(ex.Message);
            }
        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {
                if(filter==null)
                    return _dal.Customer.ReadAll().Select(s => s?.ConvertDoToBo()).ToList();
                return _dal.Customer.ReadAll(doCustomer => filter!(doCustomer.ConvertDoToBo())).Select(s => s?.ConvertDoToBo()).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(BO.Customer item)
        {
            try
            {
                _dal.Customer.Update(item.ConvertBoToDo());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
