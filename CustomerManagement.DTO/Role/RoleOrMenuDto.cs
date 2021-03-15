using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace CustomerManagement.DTO.Role
{
    /// <summary>
    ///   角色菜单关系  Dto
    /// </summary>
    public class RoleOrMenuDto
    {
        /// <summary>
        ///  编号
        /// </summary>
        public Guid Id
        {
            get; set;
        }
        /// <summary>
        ///  角色Id
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        ///  菜单Id
        /// </summary>
        public Guid MenuId { get; set; }
    }
}
