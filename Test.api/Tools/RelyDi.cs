using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.BLL.Employees;
using CustomerManagement.IBLL.IEmployees;
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
            service.AddSingleton<IEmployeesManage, EmployeesManage>();
        }
    }
}
