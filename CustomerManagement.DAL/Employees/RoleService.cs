using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.IDAL.IEmployees;
using CustomerManagement.Model;
using CustomerManagement.Model.Employees;

namespace CustomerManagement.DAL.Employees
{
    /// <summary>
    ///  实现角色接口 IDAL DAL 层
    /// </summary>
    public class RoleService:BaseService<Role>,IRoleService
    {
        public RoleService() : base(new CustomerManagementContext())
        {

        }
    }
}
