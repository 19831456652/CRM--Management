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
        /// <summary>
        ///  重写控制器
        /// </summary>
        /// <param name="roleManage"></param>
        public RoleController(IRoleManage roleManage)
        {
            _roleManage = roleManage;
        }

        // 创建私有的业务映射关系
        private readonly IRoleManage _roleManage;


        /// <summary>
        ///  获取所有角色信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllRole()
        {
            if (ModelState.IsValid)
            {
                return Ok(new EndState() {Code = 200, IsSucceed = true, Data = await _roleManage.GetAllRole(), ErrorMessage = "获取成功"});
            }

            return Ok(new EndState() {Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败"});
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
                    Code = 200,
                    IsSucceed = true,
                    ErrorMessage = "添加成功"
                });
            }

            return Ok(new EndState() {Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败"});
        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> EditRole(Guid id,RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _roleManage.EditRole(id, model.RoleName, model.RoleDescribe);
                return Ok(new EndState()
                {
                    Code = 200,
                    IsSucceed = true,
                    ErrorMessage = "修改成功"
                });
            }
            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败" });
        }

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> RemoveRole(Guid id)
        {
            if (ModelState.IsValid)
            {
                await _roleManage.RemoveRole(id);
                return Ok(new EndState()
                {
                    Code = 200,
                    IsSucceed = true,
                    ErrorMessage = "删除成功"
                });
            }
            return Ok(new EndState() { Code = 500,IsSucceed = false,ErrorMessage = "数据模型验证失败" });
        }
    }
}
