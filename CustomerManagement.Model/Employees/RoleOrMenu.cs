using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Employees
{
    /// <summary>
    ///  角色菜单关系表
    /// </summary>
    [Table("CM_RoleOrMenu")]
    public class RoleOrMenu:BaseEntity
    {
        /// <summary>
        ///  角色
        /// </summary>
        [ForeignKey(nameof(Role))]
        public Guid RoleId { get; set; }
        public Role Role { get; set; }


        /// <summary>
        ///  菜单
        /// </summary>
        [ForeignKey(nameof(Menu))]
        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
