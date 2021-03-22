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

        public async Task<List<EmployeeOrRoleDto>> GetAllEmployeesOrRole()
        {
            using IEmployeesOrRoleService employeesOrRoleService = new EmployeesOrRoleService();
            return await employeesOrRoleService.GetAllAsync().Select(i => new EmployeeOrRoleDto()
            {
                Id = i.Id,
                EmployeesId = i.UserId,
                RoleId = i.RoleId
            }).ToListAsync();
        }

        public async Task CrateData(Guid employeeId, Guid roleId)
        {
            using IEmployeesOrRoleService employeesOrRoleService = new EmployeesOrRoleService();
            await employeesOrRoleService.CreateAsync(new EmployeeOrRole()
            {
                UserId = employeeId,
                RoleId = roleId
            });
        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public async Task EditEmpOrRole(Guid id, Guid userId,Guid roleId)
        {
            using IEmployeesOrRoleService employeesOrRoleService = new EmployeesOrRoleService();
            if (await employeesOrRoleService.GetAllAsync().AnyAsync(i => i.Id == id))
            {
                var employeeOrRole = employeesOrRoleService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (employeeOrRole != null)
                {
                    employeeOrRole.UserId = userId;
                    employeeOrRole.RoleId = roleId;
                }
                await employeesOrRoleService.EditAsync(employeeOrRole);
            }
           
        }

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task RemoveRmpOrRole(Guid id)
        {
            using IEmployeesOrRoleService employeesOrRoleService = new EmployeesOrRoleService();
            if (await employeesOrRoleService.GetAllAsync().AnyAsync(i=>i.Id == id))
            {
                var employeeOrRole = employeesOrRoleService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (employeeOrRole != null)
                {
                    await employeesOrRoleService.RemoveAsync(id);
                }
            }

            
        }
    }
}
