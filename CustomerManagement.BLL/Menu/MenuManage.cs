using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DAL.Employees;
using CustomerManagement.DTO.Menu;
using CustomerManagement.IBLL.Menu;
using CustomerManagement.IDAL.IEmployees;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.BLL.Menu
{
    /// <summary>
    ///  菜单功能 BLL
    /// </summary>
    public class MenuManage:IMenuManagement
    {
        /// <summary>
        ///  获取所有菜单
        /// </summary>
        /// <returns></returns>
        public async Task<List<MenuDto>> GetAllMenu()
        {
            using IMenuService menu = new MenuService();
            return await menu.GetAllAsync().Select(i => new MenuDto()
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
            // 角色和员工的关系
            using IRoleOrMenuService roleOrMenu = new RoleOrMenuService();
            // 菜单
            using IMenuService menuService = new MenuService();
            // 菜单DTO模型
            List<MenuDto> menu = new List<MenuDto>();
            foreach (var roleOrMenu1 in roleOrMenu.GetAllAsync().Where(i=>i.Id == id))
            {
                foreach (var item in menuService.GetAllAsync().Where(i=>i.Id == roleOrMenu1.Menu.Id))
                {
                    menu.Add(new MenuDto()
                    {
                        Title = item.Title,
                        Image = item.Image,
                        MenuId = item.MMenuId,
                        Name = item.Name,
                        Path = item.Path,
                        View = item.View,
                        MenuState = item.MenuState
                    });
                }
            }
            return menu;
        }
    }
}
