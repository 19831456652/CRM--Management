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
    ///  角色菜单关系控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("any")]
    public class RoleOrMenuController : ControllerBase
    {
        /// <summary>
        ///  重写控制器
        /// </summary>
        /// <param name="roleOrMenu"></param>
        public RoleOrMenuController(IRoleOrMenuManage roleOrMenu)
        {
            _roleOrMenu = roleOrMenu;
        }

        private readonly IRoleOrMenuManage _roleOrMenu;

        /// <summary>
        ///  获取所有数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllRoleOrMenu()
        {
            if (ModelState.IsValid)
            {
                return Ok(new EndState() {Code = 200,IsSucceed = true,Data = await _roleOrMenu.GetALlRoleOrMenu(), ErrorMessage = "获取成功"});
            }

            return Ok(new EndState() {Code = 500,IsSucceed = false,ErrorMessage = "数据模型验证失败"});
        }

        /// <summary>
        ///  添加数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateData(RoleOrMenuViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _roleOrMenu.CreateData(model.RoleId, model.MenuId);
                return Ok(new EndState() {Code = 200, IsSucceed = true, ErrorMessage = "添加成功"});
            }
            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败" });
        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> EditRoleOrMenu(Guid id,RoleOrMenuViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _roleOrMenu.EditRoleOrMenu(id, model.RoleId, model.MenuId);
                return Ok(new EndState() {Code = 200, IsSucceed = true, ErrorMessage = "修改成功"});
            }
            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败" });
        }

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> RemoveRoleOrMenu(Guid id)
        {
            if (ModelState.IsValid)
            {
                await _roleOrMenu.RemoveRoleOrMenu(id);
                return Ok(new EndState() { Code = 200, IsSucceed = true, ErrorMessage = "删除成功" });
            }
            return Ok(new EndState() { Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败" });
        }
    }
}
