using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.BLL.Branch;
using CustomerManagement.BLL.Employees;
using CustomerManagement.BLL.Menu;
using CustomerManagement.BLL.Role;
using CustomerManagement.DAL.Employees;
using CustomerManagement.IBLL.Branch;
using CustomerManagement.IBLL.IEmployees;
using CustomerManagement.IBLL.Menu;
using CustomerManagement.IBLL.Role;
using CustomerManagement.IDAL.IEmployees;
using CustomerManagement.Model.Employees;
using Microsoft.Extensions.DependencyInjection;

namespace Test.api.Tools
{
    /// <summary>
    ///  依赖注入
    /// </summary>
    public class RelyDi
    {
        public static void Di(IServiceCollection service)
        {
            #region 员工

            service.AddSingleton<IEmployeesManage, EmployeesManage>();
            service.AddSingleton<IEmployeesService, EmployeesService>();
            service.AddSingleton<IEmployeesOrRoleManage, EmployeeOrRoleManage>();
            service.AddSingleton<IEmployeesOrRoleService, EmployeesOrRoleService>();

            #endregion
            #region 角色菜单

            service.AddSingleton<IRoleOrMenuManage, RoleOrMenuManage>();
            service.AddSingleton<IRoleManage, RoleManage>();
            service.AddSingleton<IRoleService, RoleService>();
            service.AddSingleton<IMenuManage, MenuManage>();
            service.AddSingleton<IMenuService, MenuService>();
            service.AddSingleton<IRoleOrMenuService, RoleOrMenuService>();
            #endregion

            #region 部门

            service.AddSingleton<IBranchManage, BranchManage>();
            service.AddSingleton<IBranchService, BranchService>();


            #endregion
        }
    }
}
