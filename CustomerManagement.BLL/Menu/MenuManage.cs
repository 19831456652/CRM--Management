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

        public async Task CrateData(string title, string image, Guid mMenuId, string name, string path, string view, bool menuState)
        {
            using MenuService menuService = new MenuService();
            await menuService.CreateAsync(new Model.Employees.Menu()
            {
                Title = title,
                Image = image,
                MMenuId = mMenuId,
                Name = name,
                Path = path,
                View = view,
                MenuState = menuState,
            });
        }

        /// <summary>
        ///  获取所有菜单
        /// </summary>
        /// <returns></returns>
        public async Task<List<MenuDto>> GetAllMenu()
        {
            using MenuService menuService = new MenuService();
            return await menuService.GetAllAsync().Select(i => new MenuDto()
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
            using RoleOrMenuService roleOrMenuService = new RoleOrMenuService();
            // 菜单DTO模型 Include 自动关联对应的表数据
            List<MenuDto> menu = new List<MenuDto>();
            List<RoleOrMenu> menus = roleOrMenuService.GetAllAsync().Where(a => a.RoleId == id).Include("Menu").ToList();
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

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="image"></param>
        /// <param name="mMenuId"></param>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="view"></param>
        /// <param name="menuState"></param>
        /// <returns></returns>
        public async Task EditMenu(Guid id, string title, string image, Guid mMenuId, string name, string path, string view,
            bool menuState)
        {
            using IMenuService menuService = new MenuService();
            if (await menuService.GetAllAsync().AnyAsync(i => i.Id == id))
            {
                var menu = menuService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (menu != null)
                {
                    menu.Title = title;
                    menu.Image = image;
                    menu.MMenuId = mMenuId;
                    menu.Name = name;
                    menu.Path = path;
                    menu.View = view;
                    menu.MenuState = menuState;
                }
                await menuService.EditAsync(menu);
            }
        }

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task RemoveMenu(Guid id)
        {
            using IMenuService menuService = new MenuService();
            if (await menuService.GetAllAsync().AnyAsync(i=>i.Id == id))
            {
                var menu = menuService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (menu != null)
                {
                    await menuService.RemoveAsync(id);
                }
            }
            
        }
    }
}
