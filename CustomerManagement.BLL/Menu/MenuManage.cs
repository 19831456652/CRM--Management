using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DAL.Employees;
using CustomerManagement.DTO.Menu;
using CustomerManagement.IBLL.Menu;
using CustomerManagement.IDAL.IEmployees;
using CustomerManagement.Model.Employees;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.BLL.Menu
{
    /// <summary>
    ///  菜单功能 BLL
    /// </summary>
    public class MenuManage:IMenuManage
    {
        public  MenuManage(IMenuService menuService, IRoleOrMenuService roleOrMenu)
        {
            _menuService = menuService;
            _roleOrMenuService = roleOrMenu;
        }

        /// <summary>
        ///  角色菜单关系注入
        /// </summary>
        private IRoleOrMenuService _roleOrMenuService;
        
        /// <summary>
        ///  菜单注入
        /// </summary>
        private IMenuService _menuService;
        /// <summary>
        ///  获取所有菜单
        /// </summary>
        /// <returns></returns>
        public async Task<List<MenuDto>> GetAllMenu()
        {
         
            return await _menuService.GetAllAsync().Select(i => new MenuDto()
            {
                Id = i.Id,
                Title = i.Title,
                Image = i.Image,
                MenuId = i.MMenuId,
                Name = i.Name,
                Path = i.Path,
                View = i.View,
                MenuState = i.MenuState
            }).ToListAsync();
        }

        /// <summary>
        ///  根据角色获取菜单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<List<MenuDto>> GetMenuByIdRoleTypeId(Guid id)
        {
            // 菜单DTO模型 Include 自动关联对应的表数据
            List<MenuDto> menu = new List<MenuDto>();
            List<RoleOrMenu> menus = _roleOrMenuService.GetAllAsync().Where(a => a.RoleId == id).Include("Menu").ToList();
            foreach (var item in menus)
            {
                menu.Add(new MenuDto()
                {
                    Id = item.Menu.Id,
                    Title = item.Menu.Title,
                    Image = item.Menu.Image,
                    MenuId = item.Menu.MMenuId,
                    Name = item.Menu.Name,
                    Path = item.Menu.Path,
                    View = item.Menu.View,
                    MenuState = item.Menu.MenuState
                });
            }
            
            return menu;
        }
    }
}
