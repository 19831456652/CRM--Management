using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.ViewModel.Role
{
    /// <summary>
    ///  角色视图模型
    /// </summary>
    public class RoleViewModel
    {
        /// <summary>
        ///  角色名称
        /// </summary>
        [StringLength(50), Required]
        public string RoleName { get; set; }

        /// <summary>
        ///  描述
        /// </summary>
        [StringLength(100)]
        public string RoleDescribe { get; set; }
    }
}
