using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.BLL.Employees;
using CustomerManagement.BLL.Role;
using CustomerManagement.IBLL.IEmployees;
using CustomerManagement.IBLL.Role;
using CustomerManagement.ViewModel.Role;
using Microsoft.AspNetCore.Cors;
using Test.api.Tools;

namespace Test.api.Controllers
{
    /// <summary>
    ///  员工角色控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("any")]
    public class EmployeesOrRoleController : ControllerBase
    {
        /// <summary>
        ///  重写控制器
        /// </summary>
        /// <param name="employeesOrRole"></param>
        public EmployeesOrRoleController(IEmployeesOrRoleManage employeesOrRole)
        {
            _employeesManage = employeesOrRole;
        }

        private readonly IEmployeesOrRoleManage _employeesManage;


        /// <summary>
        ///  获取所有数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllRoleOrMenu()
        {
            if (ModelState.IsValid)
            {
                return Ok(new EndState() { Code = 200, Data = await _employeesManage.GetAllEmployeesOrRole(), ErrorMessage = "获取成功" });
            }

            return Ok(new EndState() { Code = 500, ErrorMessage = "数据模型验证失败" });
        }

        /// <summary>
        ///  添加数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateData(EmployeesOrRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _employeesManage.CrateData(model.EmployeesId,model.RoleId);
                return Ok(new EndState() { Code = 200, ErrorMessage = "添加成功" });
            }
            return Ok(new EndState() { Code = 500, ErrorMessage = "数据模型验证失败" });
        }
    }
}
