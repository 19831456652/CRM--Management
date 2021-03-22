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

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        Task EditEmpOrRole(Guid id, Guid userId, Guid roleId);

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveRmpOrRole(Guid id);
    }
}
