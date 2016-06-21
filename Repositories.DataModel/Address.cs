namespace Ecom.DataModel
{
   public class Address
    {
        public int AddressId { get; set; }

        public int CustomerID { get; set; }

        public string AddressLine1 { get; set; }

        public string HouseNo { get; set; }

        public string AddressLine2 { get; set; }

        public string PinCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public bool IsCurrentAddress { get; set; }
    }
}
