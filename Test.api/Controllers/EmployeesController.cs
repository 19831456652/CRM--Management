using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CustomerManagement.BLL.Employees;
using CustomerManagement.IBLL.IEmployees;
using CustomerManagement.ViewModel.Employee;
using CustomerManagement.ViewModel.Role;
using Microsoft.AspNetCore.Cors;
using Test.api.Tools;

namespace Test.api.Controllers
{
    /// <summary>
    ///  员工控制器
    /// </summary>

    [ApiController]
    [Route("api/[controller]/[action]")]
    [EnableCors("any")]
    public class EmployeesController : Controller
    {
        /// <summary>
        /// 重写控制器
        /// </summary>
        /// <param name="employeesManage"></param>
        public EmployeesController(IEmployeesManage employeesManage)
        {
            _employeesManage = employeesManage;
        }

        private readonly IEmployeesManage _employeesManage;


        /// <summary>
        ///  登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public  IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var emp = _employeesManage.Login(model.Email, model.PassWord, out Guid empId);
                if (emp == true)
                {
                    return Ok(new EndState()
                    {
                        Data = JwtFactory.GetToken(new Claim[]
                        {
                            new Claim("Email", model.Email),
                            new Claim("PassWord", model.PassWord),
                        }),
                        IsSucceed = true,
                        ErrorMessage = "登录成功"
                    });
                }
                return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "账号密码错误" });
            }
            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "校验未通过" });
        }

        /// <summary>
        ///  注册
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Register(EmployeesViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _employeesManage.Register(model.TheWorkNumber, model.Password, model.Name, model.Sex, model.Age,
                    model.Phone, model.Email, model.Address, model.Image, model.Remarks, model.Status, model.BranchId);
                return Ok(new EndState() { Code = 200, IsSucceed = true, ErrorMessage = "注册成功" });
            }
            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败" });

        }

        /// <summary>
        /// 获取所有用户数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllUserAsync()
        {
            if (ModelState.IsValid)
            {
                return Ok(new EndState() { Code = 200, IsSucceed = true, Data = await _employeesManage.GetAllEmployees(), ErrorMessage = "获取数据成功" });
            }
            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "数据有误" });
        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> EditEmp(Guid id,EmployeesEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _employeesManage.EditEmp(id, model.Password, model.Name, model.Sex, model.Age,
                    model.Phone, model.Email, model.Address, model.Image, model.Remarks, model.Status, model.BranchId);
                return Ok(new EndState() { Code = 200, IsSucceed = true, ErrorMessage = "修改成功" });
            }
            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败" });

        }

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> RemoveEmp(Guid id)
        {
            if (ModelState.IsValid)
            {
                await _employeesManage.RemoveEmp(id);
                return Ok(new EndState() { Code = 200,IsSucceed = true,ErrorMessage = "删除成功" });
            }
            return Ok(new EndState() { Code = 500,IsSucceed = false,ErrorMessage = "数据模型验证失败" });
        }
    }
}
