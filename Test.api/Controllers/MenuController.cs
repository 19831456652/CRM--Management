using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.BLL.Menu;
using CustomerManagement.IBLL.Menu;
using CustomerManagement.ViewModel.Employee;
using Microsoft.AspNetCore.Cors;
using Test.api.Tools;

namespace Test.api.Controllers
{
    
    /// <summary>
    ///  菜单控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("any")]
    public class MenuController : Controller
    {
        /// <summary>
        ///  获取所有菜单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetMenu()
        {
            if (ModelState.IsValid)
            {
                IMenuManagement menuManagement = new MenuManage();
                return Ok(new EndState() {Code = 200,Data = await menuManagement.GetAllMenu(), ErrorMessage = "获取成功"});
            }
            return Ok(new EndState() {Code = 500, ErrorMessage = "数据模型验证失败"});
        }

        /// <summary>
        ///  根据角色获取菜单
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetRoleMenu(MenuViewModel model)
        {
            if (ModelState.IsValid)
            {
                IMenuManagement menuManagement = new MenuManage();
                return Ok(new EndState()
                    {Code = 200, Data = await menuManagement.GetMenuByIdRoleTypeId(model.Id), ErrorMessage = "获取成功"});
            }
            return Ok(new EndState() {Code = 500, ErrorMessage = "数据模型验证失败"});
        }
    }
}
