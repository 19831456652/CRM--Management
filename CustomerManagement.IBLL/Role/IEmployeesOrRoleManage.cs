using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DTO.Role;

namespace CustomerManagement.IBLL.Role
{
    /// <summary>
    ///  员工角色接口 IBLL
    /// </summary>
    public interface IEmployeesOrRoleManage
    {
        Task<List<EmployeeOrRoleDto>> GetAllEmployeesOrRole();
        Task CrateData(Guid employeeId, Guid roleId);
    }
}
