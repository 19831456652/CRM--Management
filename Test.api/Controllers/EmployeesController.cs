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
        ///  登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public  IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                IEmployeesManage employeesManage = new EmployeesManage();
                var emp = employeesManage.Login(model.Email, model.PassWord, out Guid empId);
                if (emp == true)
                {
                    return Ok(new EndState()
                    {
                        Data = JwtFactory.GetToken(new Claim[]
                        {
                            new Claim("Email", model.Email),
                            new Claim("PassWord", model.PassWord),
                        }),ErrorMessage = "登录成功"
                    });
                }

                return Ok(new EndState(){Code = 500,ErrorMessage = "校验未通过" });
            }
            return Ok(new EndState() {Code = 500, ErrorMessage = "账号密码错误"});
        }

        /// <summary>
        ///  注册
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Register(EmployeesViewModel model)
        {
            IEmployeesManage employeesManage = new EmployeesManage();
            await employeesManage.Register(model.TheWorkNumber, model.Password, model.Name, model.Sex, model.Age,
                model.Phone, model.Email, model.Address, model.Image, model.Remarks, model.Status, model.BranchId);
            return Ok(new EndState() { Code = 200, ErrorMessage = "注册成功" });
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
                IEmployeesManage employeesManage = new EmployeesManage();
                return Ok(new EndState() { Code = 200, Data = await employeesManage.GetAllEmployees(), ErrorMessage = "获取数据成功" });
            }
            return Ok(new EndState() { Code = 500, ErrorMessage = "数据有误" });
        }

    }
}
