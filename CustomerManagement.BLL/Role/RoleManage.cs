using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DAL.Employees;
using CustomerManagement.DTO.Role;
using CustomerManagement.IBLL.Role;
using CustomerManagement.IDAL.IEmployees;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.BLL.Role
{
    /// <summary>
    ///  实现角色功能接口  BLL
    /// </summary>
    public class RoleManage:IRoleManage
    {

        /// <summary>
        ///  重写角色实现功能接口
        /// </summary>
        public RoleManage(IRoleService roleService)
        {
            _roleService = roleService;
        }

        private readonly IRoleService _roleService;

        /// <summary>
        ///  获取所有角色信息
        /// </summary>
        /// <returns></returns>
        public async Task<List<RoleDto>> GetAllRole()
        {
            return await _roleService.GetAllAsync().Select(i => new RoleDto()
            {
                Id = i.Id,
                RoleName = i.RoleName,
                RoleDescribe = i.RoleDescribe,
            }).ToListAsync();
        }

        /// <summary>
        ///  添加角色信息
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="roleDescribe"></param>
        /// <returns></returns>
        public async Task CreateRole(string roleName, string roleDescribe)
        {
            await _roleService.CreateAsync(new Model.Employees.Role()
            {
                RoleName = roleName,
                RoleDescribe = roleDescribe
            });
        }
    }
}
