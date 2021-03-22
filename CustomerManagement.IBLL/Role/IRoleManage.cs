using System;
using System.Collections.Generic;
using System.IO.Pipes;
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

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id">角色编号</param>
        /// <param name="roleName">角色名称</param>
        /// <param name="roleDescribe">角色描述</param>
        /// <returns></returns>
        Task EditRole(Guid id, string roleName, string roleDescribe);

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id">角色编号</param>
        /// <returns></returns>
        Task RemoveRole(Guid id);
    }
}
