using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.BLL.Role;
using CustomerManagement.IBLL.Role;
using CustomerManagement.ViewModel.Role;
using Microsoft.AspNetCore.Cors;
using Test.api.Tools;

namespace Test.api.Controllers
{
    /// <summary>
    ///  角色控制器
    /// </summary>
    [EnableCors("any")]
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        // 创建私有的业务映射关系
        private readonly IRoleManage _roleManage = new RoleManage();


        /// <summary>
        ///  获取所有角色信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllRole()
        {
            if (ModelState.IsValid)
            {
                return Ok(new EndState() {Code = 200, Data = await _roleManage.GetAllRole(), ErrorMessage = "获取成功"});
            }

            return Ok(new EndState() {Code = 500, ErrorMessage = "数据模型验证失败"});
        }


        /// <summary>
        ///  添加角色信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateAllRole(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _roleManage.CreateRole(model.RoleName, model.RoleDescribe);
                return Ok(new EndState()
                {
                    Code = 200, ErrorMessage = "添加成功"
                });
            }

            return Ok(new EndState() {Code = 500, ErrorMessage = "数据模型验证失败"});
        }
    }
}
