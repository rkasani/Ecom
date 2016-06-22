namespace Ecom.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;    /// <summary>
                                                    /// Product class representing Items
                                                    /// </summary>
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string PrductName { get; set; }

        public string Specifications { get; set; }

        public string TechnicalSpecs { get; set; }

        public Category CategoryId { get; set; }
    }
}
