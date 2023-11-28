namespace LandPApi.Dto
{
    public class CustomerForAdminDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int AmountOrder { get; set; }
        public bool LockoutEnabled { get; set; }
        //public DateTime? LockoutEnd { get; set; } = null;
    }
}
