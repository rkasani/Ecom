namespace Ecom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;    /// <summary>
                                                    /// Class handles the Default price of Product
                                                    /// </summary>
    public class PriceTag
    {
        /// <summary>
        /// Gets or Sets the UniqueId for unit price of a product.
        /// </summary>
        [Key]
        public int PriceTagId { get; set; }
        /// <summary>
        /// Gets or Sets The unit price of the product
        /// </summary>
        /// 
        public int ProductId { get; set; }

        
        public double UnitPrice { get; set; }
        /// <summary>
        /// Gets or Sets the Date of the unit price entered into the system.
        /// </summary>
        public DateTime PriceEnteredDate { get; set; }
        /// <summary>
        /// Gets or Sets whether the price is current item price
        /// </summary>
        public bool IsCurrentRate { get; set; }
        /// <summary>
        /// Gets Or Sets the offer price data
        /// </summary>
        public bool IsOfferPrice { get; set; }

        public virtual Product Product { get; set; }
    }
}
