using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.IDAL.IEmployees;
using CustomerManagement.Model;
using CustomerManagement.Model.Employees;

namespace CustomerManagement.DAL.Employees
{
    /// <summary>
    ///  实现角色菜单接口 IDAL DAL 层
    /// </summary>
    public class RoleOrMenuService:BaseService<RoleOrMenu>,IRoleOrMenuService
    {
        public RoleOrMenuService() : base(new CustomerManagementContext())
        {

        }
    }
}
