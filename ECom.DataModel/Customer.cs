namespace Ecom.DataModel
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;    /// <summary>
                                                    /// Handles Customer information 
                                                    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or Sets Customer UniqueID
        /// </summary>
        [Key]
        public int CustomerID { get; set; }
        /// <summary>
        /// Gets or Sets first name of customer
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets middle name of customer
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Gets or Sets last name of customer
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets Mobile Number of customer
        /// </summary>
        public string MobileNo { get; set; }
        /// <summary>
        /// Gets or Sets Email Address of customer
        /// </summary>
        public string EmailId { get; set; }
        /// <summary>
        /// Gets or Sets if customer has activated his account
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Gets or Sets customer registeredDate
        /// </summary>
        public DateTime RegistrationDate { get; set; }
        /// <summary>
        /// Gets or Sets customer asked for a delete request
        /// </summary>
        public bool IsDeleted { get; set; }

        public ICollection<Address> ShippingAddress { get; set; }

    }
}
