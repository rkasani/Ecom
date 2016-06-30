using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Dto
{
    using Ecom.DataModel;
    public class ProductDto
    {
        public ProductDto()
        { }

        public int ProductID { get; set; }

        public string  ProductName { get; set; }

        public List<PriceTag> PriceTags { get; set; }

        public List<ProductImage> ImageUrls { get; set; }

        public List<Category>  Categories { get; set; }        
    }
}
