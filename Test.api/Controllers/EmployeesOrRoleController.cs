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
                return Ok(new EndState() { Code = 200, IsSucceed = true, Data = await _employeesManage.GetAllEmployeesOrRole(), ErrorMessage = "获取成功" });
            }

            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败" });
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
                await _employeesManage.CrateData(model.UserId,model.RoleId);
                return Ok(new EndState() { Code = 200, IsSucceed = true, ErrorMessage = "添加成功" });
            }
            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败" });
        }

        /// <summary>
        ///  修改员工角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> EditEmpOrRole(Guid id,EmployeesOrRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _employeesManage.EditEmpOrRole(id, model.UserId, model.RoleId);
                return Ok(new EndState() { Code = 200,IsSucceed = true,ErrorMessage = "修改成功" });
            }
            return Ok(new EndState() { Code = 500,IsSucceed = false,ErrorMessage = "数据模型验证失败" });
        }

        /// <summary>
        ///  删除员工角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> RemoveEmpOrRole(Guid id)
        {
            if (ModelState.IsValid)
            {
                await _employeesManage.RemoveRmpOrRole(id);
                return Ok(new EndState() { Code = 200, IsSucceed = true, ErrorMessage = "删除成功" });
            }
            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败" });
        }
    }
}
