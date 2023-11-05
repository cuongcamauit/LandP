namespace LandPApi.View
{
    public class MenuView
    {
        // 1 item in menu is a slug
        public string? slugId { get; set; }
        // with item lv2
        public string? ParentId { get; set; } = null;
    }
}
