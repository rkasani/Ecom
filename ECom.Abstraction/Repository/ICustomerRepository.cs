using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecom.DataModel;

namespace ECom.Abstraction.Repository
{
    interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        void Add(Customer entity);
        void Delete(Customer entity);
        Customer Get(int CustomerId);

    }
}
