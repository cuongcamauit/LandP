namespace LandPApi.Dto
{
    public class ShipInfor
    {
        public int from_district_id { get; set; }
        public string from_ward_code { get; set; }
        public int service_id { get; set; } = 53320;
        public int service_type_id { get; set; }
        public int to_district_id { get; set; }
        public string to_ward_code { get; set; }
        public int height { get; set; }
        public int length { get; set; }
        public int weight { get; set; }
        public int width { get; set; }
        public int insurance_value { get; set; } = 0;
        public int cod_failed_amount { get; set; } = 0;
        public string coupon { get; set; } = null;
    }
}
