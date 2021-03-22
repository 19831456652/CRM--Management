using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CustomerManagement.IDAL.IEmployees;
using CustomerManagement.Model;
using CustomerManagement.Model.Employees;

namespace CustomerManagement.DAL.Employees
{
    /// <summary>
    ///  实现部门接口 IDAL DAL层
    /// </summary>
    public class BranchService:BaseService<Branch>,IBranchService
    {
        public BranchService():base(new CustomerManagementContext()){}
    }
}
