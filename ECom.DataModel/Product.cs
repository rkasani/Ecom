namespace Ecom.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;    
    /// <summary>
    /// Product class representing Items
    /// </summary>
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Specifications { get; set; }

        public string TechnicalSpecs { get; set; }

        public bool IsProductActive { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

        
        public ICollection<Category> Categories { get; set; }

        public ICollection<PriceTag> Prices { get; set; }
    }
}
