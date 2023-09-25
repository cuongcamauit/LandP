namespace LandPApi.Dto
{
    public class AddressDto
    {
        public Guid Id { get; set; }
        public string? ProvinceName { get; set; }
        public int ProvinceId { get; set; }
        public string? DistrictName { get; set; }
        public int DistrictId { get; set; }
        public string? WardName { get; set; }
        public string? WardCode { get; set; }
        public string? Detail { get; set; }
        public string? CustomerId { get; set; }
        public bool isDefault { get; set; }
    }
}
