using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DAL.Employees;
using CustomerManagement.DTO.Role;
using CustomerManagement.IBLL.Role;
using CustomerManagement.IDAL.IEmployees;
using CustomerManagement.Model.Employees;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.BLL.Role
{
    public class RoleOrMenuManage:IRoleOrMenuManage
    {

        /// <summary>
        ///  获取所有数据
        /// </summary>
        /// <returns></returns>
        public async Task<List<RoleOrMenuDto>> GetALlRoleOrMenu()
        {
            using RoleOrMenuService roleOrMenuService = new RoleOrMenuService();
            return await roleOrMenuService.GetAllAsync().Select(i => new RoleOrMenuDto()
            {
                Id = i.Id,
                RoleId = i.RoleId,
                MenuId = i.MenuId
            }).ToListAsync();
        }

        /// <summary>
        ///  添加数据
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public async Task CreateData(Guid roleId, Guid menuId)
        {
            using RoleOrMenuService roleOrMenuService = new RoleOrMenuService();
            await roleOrMenuService.CreateAsync(new RoleOrMenu()
            {
                RoleId = roleId,
                MenuId = menuId,
            });
        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roleId"></param>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public async Task EditRoleOrMenu(Guid id, Guid roleId, Guid menuId)
        {
            using RoleOrMenuService roleOrMenuService = new RoleOrMenuService();
            if (await roleOrMenuService.GetAllAsync().AnyAsync(i => i.Id == id))
            {
                var roleOrMenu = roleOrMenuService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (roleOrMenu != null)
                {
                    roleOrMenu.RoleId = roleId;
                    roleOrMenu.MenuId = menuId;
                }
                await roleOrMenuService.EditAsync(roleOrMenu);
            }
            
        }

        /// <summary>
        ///  删除z
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task RemoveRoleOrMenu(Guid id)
        {
            using RoleOrMenuService roleOrMenuService = new RoleOrMenuService();
            if (await roleOrMenuService.GetAllAsync().AnyAsync(i=>i.Id == id))
            {
                var roleOrMenu = roleOrMenuService.GetAllAsync().FirstOrDefault(i => i.Id == id);

                if (roleOrMenu != null)
                {
                    await roleOrMenuService.RemoveAsync(id);
                }
            }
        }
    }
}
