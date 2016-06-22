namespace Ecom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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

        public IEnumerable<Product> Products { get; set; }
    }
}
