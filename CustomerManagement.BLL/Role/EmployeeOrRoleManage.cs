using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DAL.Employees;
using CustomerManagement.DTO.Role;
using CustomerManagement.IBLL.Role;
using CustomerManagement.IDAL.IEmployees;
using CustomerManagement.Model.Employees;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.BLL.Role
{
    /// <summary>
    ///  员工角色关系功能 BLl
    /// </summary>
    public class EmployeeOrRoleManage:IEmployeesOrRoleManage
    {

        public EmployeeOrRoleManage(IEmployeesOrRoleService employeesOrRole)
        {
            _employeesOrRoleService = employeesOrRole;
        }


        private readonly IEmployeesOrRoleService _employeesOrRoleService;


        public async Task<List<EmployeeOrRoleDto>> GetAllEmployeesOrRole()
        {
            return await _employeesOrRoleService.GetAllAsync().Select(i => new EmployeeOrRoleDto()
            {
                Id = i.Id,
                EmployeesId = i.UserId,
                RoleId = i.RoleId
            }).ToListAsync();
        }

        public async Task CrateData(Guid employeeId, Guid roleId)
        {
            await _employeesOrRoleService.CreateAsync(new EmployeeOrRole()
            {
                UserId = employeeId,
                RoleId = roleId
            });
        }
    }
}
