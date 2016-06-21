namespace Ecom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer
    {
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int MobileNo { get; set; }

        public string EmailId { get; set; }

        public bool IsActive { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsDeleted { get; set; }
        
    }
}
