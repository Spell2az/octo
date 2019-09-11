namespace Core.Domain.Domain
{
    public class DeliveryAddress
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public bool IsDefault { get; set; }
    }
}