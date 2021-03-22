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
    public interface IMenuManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="title">名称</param>
        /// <param name="image">图标</param>
        /// <param name="mMenuId">父级</param>
        /// <param name="name">名称</param>
        /// <param name="path">页面名称</param>
        /// <param name="view">页面路径</param>
        /// <param name="menuState">状态</param>
        /// <returns></returns>
        Task CrateData(string title,string image,Guid mMenuId,string name, string path,string view,bool menuState);

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
        Task EditMenu(Guid id, string title, string image, Guid mMenuId, string name, string path, string view, bool menuState);

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveMenu(Guid id);
    }
}
