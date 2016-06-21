namespace Ecom.DataModel
{
    /// <summary>
    /// Product class representing Items
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }

        public string  Name { get; set; }

        public string Specifications { get; set; }

        public string TechnicalSpecs { get; set; }

        public Category Category { get; set; }

    }
}
