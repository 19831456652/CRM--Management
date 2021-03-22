using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CustomerManagement.IBLL.Branch;
using CustomerManagement.ViewModel.Branch;
using Microsoft.AspNetCore.Cors;
using Test.api.Tools;

namespace Test.api.Controllers
{
    /// <summary>
    ///  部门控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("any")]
    public class BranchController : ControllerBase
    {
        private readonly IBranchManage _branchManage;
        /// <summary>
        ///  重写控制器
        /// </summary>
        /// <param name="branchManage"></param>
        public BranchController(IBranchManage branchManage)
        {
            _branchManage = branchManage;
        }

        /// <summary>
        ///  获取所有部门
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllBranch()
        {
            if (ModelState.IsValid)
            {
                return Ok(new EndState() {Code = 200,IsSucceed = true,Data = await _branchManage.GetAllBranch(), ErrorMessage = "获取成功"});
            }
        
            return Ok(new EndState() {Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败"});
        }

        // /// <summary>
        // ///  获取所有数据不用异步
        // /// </summary>
        // /// <returns></returns>
        // [HttpGet]
        // public IActionResult GetAllBranch()
        // {
        //     if (ModelState.IsValid)
        //     {
        //         return Ok(new EndState() {Code = 200, Data = _branchManage.GetAll(), ErrorMessage = "获取数据"});
        //     }
        //     return Ok(new EndState() {Code = 500, ErrorMessage = "数据模型验证失败"});
        //
        // }

        /// <summary>
        ///  添加
        /// </summary>
        /// <param name="model">模型</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateBranch(BranchViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _branchManage.CrateData(model.BranchName);
                return Ok(new EndState() {Code = 200, IsSucceed = true, ErrorMessage = "添加成功"});
            }

            return Ok(new EndState() {Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败"});
        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="model">部门视图模型</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> EditBranch(Guid id,BranchViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _branchManage.EditBranch(id, model.BranchName);
                return Ok(new EndState() {Code = 200, IsSucceed = true, ErrorMessage = "修改成功"});
            }
            return Ok(new EndState() {Code = 500, IsSucceed = false, ErrorMessage = "数据模型验证失败"});
        }

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> RemoveBranch(Guid id)
        {
            if (ModelState.IsValid)
            {
                await _branchManage.RemoveBranch(id);
                return Ok(new EndState() {Code = 200,IsSucceed = true,ErrorMessage = "删除成功"});
            }
            return Ok(new EndState() {Code = 500,IsSucceed = false,ErrorMessage = "数据模型验证失败"});
        }
    }
}
