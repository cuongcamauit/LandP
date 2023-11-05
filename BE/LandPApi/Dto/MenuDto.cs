namespace LandPApi.Dto
{
    public class MenuDto
    {
        // 1 item in menu is a slug
        public String? SlugId { get; set; }
        public String? SlugName { get; set; }
        // with item lv1
        public ICollection<MenuDto>? ChildrenMenu { get; set; }
    }
}
