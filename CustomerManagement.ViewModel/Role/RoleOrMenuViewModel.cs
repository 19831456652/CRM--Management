using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.ViewModel.Role
{
    /// <summary>
    ///  角色菜单关系视图模型
    /// </summary>
    public class RoleOrMenuViewModel
    {
        public Guid RoleId { get; set; }
        public Guid MenuId { get; set; }
    }
}
