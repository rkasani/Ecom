namespace Ecom.DataModel
{
    using System;
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
        /// Gets or Sets the Product Id for mapping to unit price.
        /// </summary>
        public Product ProductId { get; set; }
        /// <summary>
        /// Gets or Sets The unit price of the product
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// Gets or Sets the Date of the unit price entered into the system.
        /// </summary>
        public DateTime PriceEnteredDate { get; set; }
        /// <summary>
        /// Gets or Sets whether the price is current item price
        /// </summary>
        public bool IsCurrentRate { get; set; }

        public IEquatable<Product> Products { get; set; }
    }
}
