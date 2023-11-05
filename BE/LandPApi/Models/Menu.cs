namespace LandPApi.Models
{
    public class Menu
    {
        // 1 item in menu is a slug
        public String slugId { get; set; }
        public Slug? Slug { get; set; }
        // with item lv1
        public ICollection<Menu>? ChildrenMenu { get; set; }
        // with item lv2
        public String? ParentId { get; set; } = null;
        public Menu? ParentMenu { get; set; } = null;
    }
}
