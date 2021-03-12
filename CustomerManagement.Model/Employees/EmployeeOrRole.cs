using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Employees
{
    /// <summary>
    ///  员工角色权限关系表
    /// </summary>
    [Table("CM_EmployeeOrRole")]
    public class EmployeeOrRole:BaseEntity
    {
        /// <summary>
        ///  员工
        /// </summary>
        [ForeignKey(nameof(Employee))]
        public Guid UserId { get; set; }
        public Employees Employee { get; set; }



        /// <summary>
        ///  角色
        /// </summary>
        [ForeignKey(nameof(Role))]
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}
