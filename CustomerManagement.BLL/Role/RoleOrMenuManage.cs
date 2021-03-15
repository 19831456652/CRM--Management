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
        public RoleOrMenuManage(IRoleOrMenuService roleOrMenu)
        {
            _roleOrMenu = roleOrMenu;
        }

        private readonly IRoleOrMenuService _roleOrMenu;

        /// <summary>
        ///  获取所有数据
        /// </summary>
        /// <returns></returns>
        public async Task<List<RoleOrMenuDto>> GetALlRoleOrMenu()
        {
            return await _roleOrMenu.GetAllAsync().Select(i => new RoleOrMenuDto()
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
            await _roleOrMenu.CreateAsync(new RoleOrMenu()
            {
                RoleId = roleId,
                MenuId = menuId,
            });
        }
    }
}
