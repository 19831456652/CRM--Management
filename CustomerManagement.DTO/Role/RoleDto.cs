using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.DTO.Role
{
    /// <summary>
    ///  角色 DTO
    /// </summary>
    public class RoleDto
    {
        /// <summary>
        ///  编号
        /// </summary>
        public Guid Id { get; set; }

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
