namespace Ecom.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
   
    /// <summary>
    /// Gives the category of identity
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or Sets the CategoryID
        /// </summary>
        [Key]
        public int CategoryID { get; set; }
        
        /// <summary>
        /// Gets or Sets the CategoryName
        /// </summary>
        public string CategoryName { get; set; }
        
        /// <summary>
        /// Gets Or sets the product Id
        /// </summary>
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        
    }
}
