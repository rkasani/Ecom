using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecom.DataModel;

namespace ECom.Dto
{
    public class CustomerDTO
    {
        public CustomerDTO()
        {

        }

        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string MobileNumber { get; set; }

        public string EmailId { get; set; }

        public bool IsActive { get; set; }

        public List<Address> Address { get; set; }
    }
}
