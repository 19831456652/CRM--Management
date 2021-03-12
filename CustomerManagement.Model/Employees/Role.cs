using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Employees
{
    /// <summary>
    ///  角色表
    /// </summary>
    [Table("CM_Role")]
    public class Role:BaseEntity
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
