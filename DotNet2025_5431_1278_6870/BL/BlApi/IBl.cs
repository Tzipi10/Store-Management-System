using BLApi;

namespace BlApi
{
    public interface IBl
    {
        ICustomer Customer { get; } 
        IProduct Product { get; }
        ISale sale { get; } 
        IOrder Order { get; }   
    }
}
