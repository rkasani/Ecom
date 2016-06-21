namespace Ecom.DataModel
{
    /// <summary>
    /// Class regarding the Image of Product
    /// </summary>
    public class ProductImage
    {
        /// <summary>
        /// Gets or Sets the ImageIf
        /// </summary>
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

    }
}
