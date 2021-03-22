using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DTO.Role;

namespace CustomerManagement.IBLL.Role
{
    /// <summary>
    ///  角色菜单关系  IBLL
    /// </summary>
    public interface IRoleOrMenuManage
    {
        /// <summary>
        ///  获取所有角色菜单关系数据
        /// </summary>
        /// <returns></returns>
        Task<List<RoleOrMenuDto>> GetALlRoleOrMenu();

        /// <summary>
        ///  添加角色菜单数据
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="menuId"></param>
        /// <returns></returns>
        Task CreateData(Guid roleId, Guid menuId);

        /// <summary>
        ///  修改角色菜单数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roleId"></param>
        /// <param name="menuId"></param>
        /// <returns></returns>
        Task EditRoleOrMenu(Guid id, Guid roleId, Guid menuId);

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveRoleOrMenu(Guid id);

    }
}
