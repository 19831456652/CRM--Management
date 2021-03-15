using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.DTO.Role
{
    /// <summary>
    ///  员工角色关系  DTO
    /// </summary>
    public  class EmployeeOrRoleDto
    {
        public Guid Id { get; set; }
        public Guid EmployeesId { get; set; }
        public Guid RoleId { get; set; }
    }
}
