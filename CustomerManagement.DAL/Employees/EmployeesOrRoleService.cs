using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.IDAL.IEmployees;
using CustomerManagement.Model;
using CustomerManagement.Model.Employees;

namespace CustomerManagement.DAL.Employees
{
    /// <summary>
    ///  实现员工角色接口 IDAL DAL 层
    /// </summary>
    public class EmployeesOrRoleService:BaseService<EmployeeOrRole>,IEmployeesOrRoleService
    {
        public EmployeesOrRoleService() : base(new CustomerManagementContext())
        {

        }
    }
}
