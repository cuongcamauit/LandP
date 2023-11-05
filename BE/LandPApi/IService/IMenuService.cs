using LandPApi.Dto;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IMenuService
    {
        public List<MenuDto> GetAll();
        public void Create(MenuView menuView);
    }
}
