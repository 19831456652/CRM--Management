using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
                return Ok(new EndState() {Code = 200, Data = await _branchManage.GetAllBranch(), ErrorMessage = "获取成功"});
            }

            return Ok(new EndState() {Code = 500, ErrorMessage = "数据模型验证失败"});
        }

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
                return Ok(new EndState() {Code = 200, ErrorMessage = "添加成功"});
            }

            return Ok(new EndState() {Code = 500, ErrorMessage = "数据模型验证失败"});
        }
    }
}
