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
        ///  获取所有角色信息
        /// </summary>
        /// <returns></returns>
        public async Task<List<RoleDto>> GetAllRole()
        {
            using IRoleService roleService = new RoleService();
            return await roleService.GetAllAsync().Select(i => new RoleDto()
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
            using IRoleService roleService = new RoleService();
            await roleService.CreateAsync(new Model.Employees.Role()
            {
                RoleName = roleName,
                RoleDescribe = roleDescribe
            });
        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id">角色编号</param>
        /// <param name="roleName">角色名称</param>
        /// <param name="roleDescribe">角色描述</param>
        /// <returns></returns>
        public async Task EditRole(Guid id, string roleName, string roleDescribe)
        {
            using IRoleService roleService = new RoleService();
            if (await roleService.GetAllAsync().AnyAsync(i => i.Id == id))
            {
                var role = roleService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (role != null)
                {
                    role.RoleName = roleName;
                    role.RoleDescribe = roleDescribe;
                }
                await roleService.EditAsync(role);
            }
            
           
        }


        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id">角色编号</param>
        /// <returns></returns>
        public async Task RemoveRole(Guid id)
        {
            using IRoleService roleService = new RoleService();
            if (await roleService.GetAllAsync().AnyAsync(i=>i.Id == id))
            {
                var role = roleService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (role != null)
                {
                    await roleService.RemoveAsync(id);
                }
            }
            
        }
    }
}
