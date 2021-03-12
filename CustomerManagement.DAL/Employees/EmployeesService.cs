using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.IDAL.IEmployees;
using CustomerManagement.Model;

namespace CustomerManagement.DAL.Employees
{
    /// <summary>
    ///  员工实现 IDAL 接口  DAL 层
    /// </summary>
    public class EmployeesService:BaseService<Model.Employees.Employees>,IEmployeesService
    {
        public EmployeesService() : base(new CustomerManagementContext())
        {

        }
    }
}
