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
        ///  重写控制器
        /// </summary>
        /// <param name="menuManagement"></param>
        public MenuController(IMenuManage menuManagement)
        {
            _menuManagement = menuManagement;
        }

        private readonly IMenuManage _menuManagement;
        /// <summary>
        ///  获取所有菜单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetMenu()
        {
            if (ModelState.IsValid)
            {
                
                return Ok(new EndState() {Code = 200, IsSucceed = true, Data = await _menuManagement.GetAllMenu(), ErrorMessage = "获取成功"});
            }
            return Ok(new EndState() {Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败"});
        }

        /// <summary>
        ///  根据角色获取菜单
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetRoleMenu(Guid id)
        {
            if (ModelState.IsValid)
            {
                return Ok(new EndState()
                    {Code = 200, IsSucceed = true, Data = await _menuManagement.GetMenuByIdRoleTypeId(id), ErrorMessage = "获取成功"});
            }
            return Ok(new EndState() {Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败"});
        }

        /// <summary>
        ///  添加菜单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateData(MenuAllViewModel model)
        {
            if (ModelState.IsValid)
            {

                await _menuManagement.CrateData(model.Title, model.Image, model.MMenuId, model.Name, model.Path,
                    model.View, model.MenuState);
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
        public async Task<IActionResult> EditMenu(Guid id,MenuAllViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _menuManagement.EditMenu(id, model.Title, model.Image, model.MMenuId, model.Name, model.Path,
                    model.View, model.MenuState);
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
        public async Task<IActionResult> RemoveMenu(Guid id)
        {
            if (ModelState.IsValid)
            {
                await _menuManagement.RemoveMenu(id);
                return Ok(new EndState() { Code = 200,IsSucceed = true,ErrorMessage = "删除成功" });
            }
            return Ok(new EndState() { Code = 500,IsSucceed = false,ErrorMessage = "数据模型验证失败" });
        }
    }
}
