namespace ECom.DataModel
{
    
    using System.Data.Entity;
    using Ecom.DataModel;


    public class EcomContext : DbContext
    {
        public EcomContext() : base("name=EcomEntities")
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<PriceTag> PriceTags { get; set; }
        public DbSet<Product> Products { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
