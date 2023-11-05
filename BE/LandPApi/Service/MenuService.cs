using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class MenuService : IMenuService
    {
        private readonly IRepository<Menu> _repository;
        private readonly IMapper _mapper;
        private readonly IRepository<Slug> _reposlug;

        public MenuService(IRepository<Menu> repository, IMapper mapper, IRepository<Slug> reposlug)
        {
            _repository = repository;
            _mapper = mapper;
            _reposlug = reposlug;
        }
        public void Create(MenuView menuView)
        {
            var menu = _mapper.Map<Menu>(menuView);
            _repository.Create(menu);
            var slug = _reposlug.ReadByCondition(o => o.Id == menuView.slugId).FirstOrDefault();
            slug!.MenuId = menuView.slugId;
            _reposlug.Update(slug);
            _repository.Save();
            _reposlug.Save();

        }

        public List<MenuDto> GetAll()
        {
            var menus = _repository.ReadByCondition(o => o.ParentMenu == null)
                                .Include(o => o.Slug)
                                .Include(o => o.ChildrenMenu)!
                                .ThenInclude(o => o.Slug)
                                .ToList();
            return _mapper.Map<List<MenuDto>>(menus);
        }
    }
}
