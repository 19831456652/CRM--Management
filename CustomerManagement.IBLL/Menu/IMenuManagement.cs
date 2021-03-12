using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DTO.Menu;

namespace CustomerManagement.IBLL.Menu
{
    /// <summary>
    ///  菜单功能接口 IBLL
    /// </summary>
    public interface IMenuManagement
    {
        /// <summary>
        ///  获取所有菜单
        /// </summary>
        /// <returns></returns>
        Task<List<MenuDto>> GetAllMenu();

        /// <summary>
        ///  根绝角色权限获取菜单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<MenuDto>> GetMenuByIdRoleTypeId(Guid id);
    }
}
