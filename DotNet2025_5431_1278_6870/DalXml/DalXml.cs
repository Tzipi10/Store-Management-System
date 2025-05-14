using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;

namespace Dal
{
    public class DalXml : IDal
    {
        public ISale Sale =>  new SaleImplementation();

        public IProduct Product =>  new ProductImplementation();

        public ICustomer Customer =>  new CustomerImplementation();

        static readonly DalXml instance = new DalXml();
        public static DalXml Instance { get { return instance; } }
        private DalXml() {
        }
    }
}
