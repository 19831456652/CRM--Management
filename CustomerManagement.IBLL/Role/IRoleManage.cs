using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DTO.Role;

namespace CustomerManagement.IBLL.Role
{
    /// <summary>
    ///  角色接口  IBLL 层
    /// </summary>
    public interface IRoleManage
    {
        /// <summary>
        ///  获取所有角色信息
        /// </summary>
        /// <returns></returns>
        Task<List<RoleDto>> GetAllRole();

        /// <summary>
        ///  添加角色
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="roleDescribe"></param>
        /// <returns></returns>
        Task CreateRole(string roleName,string roleDescribe);
    }
}
