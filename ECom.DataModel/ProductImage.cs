namespace Ecom.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    /// <summary>
    /// Class regarding the Image of Product
    /// </summary>
    public class ProductImage
    {
        /// <summary>
        /// Gets or Sets the ImageIf
        /// </summary>
        [Key]
        public int ImageId { get; set; }
        /// <summary>
        /// Gets or Sets the Mapping productId
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Gets or Sets the Image Name or Unique name
        /// </summary>
        public string ImageUniqueId { get; set; }
        /// <summary>
        /// Gets or Sets if the Image is update or not.
        /// </summary>
        public bool IsActiveImage { get; set; }
        /// <summary>
        /// Gets or Sets the Image order when it is shown to user
        /// </summary>
        public int OrderOfImage { get; set; }

        public virtual Product Product { get; set; }
    }
}
