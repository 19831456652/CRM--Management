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
                return Ok(new EndState() {Code = 200, Data = await _roleOrMenu.GetALlRoleOrMenu(), ErrorMessage = "获取成功"});
            }

            return Ok(new EndState() {Code = 500, ErrorMessage = "数据模型验证失败"});
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
                return Ok(new EndState() {Code = 200, ErrorMessage = "添加成功"});
            }
            return Ok(new EndState() { Code = 500, ErrorMessage = "数据模型验证失败" });
        }
    }
}
