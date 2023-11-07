namespace LandPApi.Dto
{
    public class Attribute
    {
        public int? Code { get; set; }
        public List<int>? OptionsId { get; set; }
    }
    public class Filter
    {
        public List<Attribute>? Attributes { get; set; }
        public List<Guid>? Brands { get; set; }
        public List<Guid>? Categories { get; set; }
        public double PriceGte { get; set; }
        public double PriceLte { get; set; }
    }
    public class Pagination
    {
        public int ItemsPerPage { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
    }
    public class Sorting
    {
        // SORT_BY_DISCOUNT_PERCENT, SORT_BY_PUBLISH_AT, SORT_BY_TOP_SALE_QUANTITy_7_DAY
        public string Sort { get; set; } = "SORT_BY_PRICE";
        // ORDER_BY_DESCENDING
        public string Order { get; set; } = "ORDER_BY_ASCENDING";
    }
    public class SearchInfor
    {
        public Filter? Filter { get; set; }
        public Pagination? Pagination { get; set; }
        public string Query { get; set; } = "";
        public Sorting? Sorting { get; set; }
        public String? Slug { get; set; }
    }
}
