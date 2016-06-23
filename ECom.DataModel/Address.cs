using System.ComponentModel.DataAnnotations;

namespace Ecom.DataModel
{
    /// <summary>
    /// Handles customer address or shipping details
    /// </summary>
   public class Address
    {
        /// <summary>
        /// Gets or Sets AddressId
        /// </summary>
        [Key]
        public int AddressId { get; set; }
        /// <summary>
        /// Gets or Sets customerID
        /// </summary>
        public Customer CustomerID { get; set; }
        /// <summary>
        /// Gets or Sets Address as line 1 
        /// Mandatory field
        /// </summary>
        public string AddressLine1 { get; set; }
        /// <summary>
        /// Gets or Sets House number
        /// </summary>
        public string HouseNo { get; set; }
        /// <summary>
        /// Gets or Sets Address as line 2
        /// </summary>
        public string AddressLine2 { get; set; }
        /// <summary>
        /// Address pincode
        /// </summary>
        public string PinCode { get; set; }
        /// <summary>
        /// Gets or Sets Address City
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Gets or Sets Address country
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Gets or Sets the following address is current
        /// </summary>
        public bool IsCurrentAddress { get; set; }
    }
}
