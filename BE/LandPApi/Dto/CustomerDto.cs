using Org.BouncyCastle.Bcpg.OpenPgp;

namespace LandPApi.Dto
{
    public class CustomerDto
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
