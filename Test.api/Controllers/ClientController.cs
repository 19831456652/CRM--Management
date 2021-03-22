using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.IBLL.Client;
using CustomerManagement.ViewModel.Client;
using Microsoft.AspNetCore.Cors;
using Test.api.Tools;

namespace Test.api.Controllers
{
    /// <summary>
    ///  客户控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("any")]
    public class ClientController : ControllerBase
    {

        private readonly IClientManage _clientManage;
        /// <summary>
        ///  重写客户控制器
        /// </summary>
        /// <param name="clientManage"></param>
        public ClientController(IClientManage clientManage)
        {
            _clientManage = clientManage;
        }

        /// <summary>
        ///  添加客户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Register(ClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _clientManage.Register(model.ClientName, model.ClientSourceId, model.Phone, model.Email,
                    model.ClientTradeId, model.ClientLevel, model.NextContactDate, model.Remarks, model.Province,
                    model.City, model.Area, model.DetailsAddress, model.ClientStatus, model.Founder, model.Principal);
                return Ok(new EndState() {Code = 200,IsSucceed = true,ErrorMessage = "客户添加成功"});
            }
            return Ok(new EndState() { Code = 500,IsSucceed = false,ErrorMessage = "数据模型验证失败" });
        }
    }
}
