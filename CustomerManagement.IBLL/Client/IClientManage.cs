using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DTO.Client;

namespace CustomerManagement.IBLL.Client
{
    /// <summary>
    ///  客户的功能接口 IBLL
    /// </summary>
    public interface IClientManage
    {
        /// <summary>
        ///  添加客户
        /// </summary>
        /// <param name="clientName">名称</param>
        /// <param name="clientSourceId">来源</param>
        /// <param name="phone">电话</param>
        /// <param name="email">邮箱</param>
        /// <param name="clientTradeId">客户行业</param>
        /// <param name="clientLevel">客户级别</param>
        /// <param name="nextContactDate">下次联系时间</param>
        /// <param name="remarks">备注</param>
        /// <param name="province">省</param>
        /// <param name="city">市</param>
        /// <param name="area">区</param>
        /// <param name="detailsAddress">详情地址</param>
        /// <param name="clientStatus">客户成交状态</param>
        /// <param name="founder">创建人</param>
        /// <param name="principal">负责人</param>
        /// <returns></returns>
        Task Register(string clientName,Guid clientSourceId,string phone,string email,Guid clientTradeId,string clientLevel,DateTime nextContactDate,string remarks,string province,string city,string area,string detailsAddress,bool clientStatus,string founder,string principal);

        /// <summary>
        ///  获取所有客户
        /// </summary>
        /// <returns></returns>
        Task<List<ClientDto>> GetAllClient();

        /// <summary>
        ///  修改客户信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clientName"></param>
        /// <param name="clientSourceId"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="clientTradeId"></param>
        /// <param name="clientLevel"></param>
        /// <param name="nextContactDate"></param>
        /// <param name="remarks"></param>
        /// <param name="province"></param>
        /// <param name="city"></param>
        /// <param name="area"></param>
        /// <param name="detailsAddress"></param>
        /// <param name="clientStatus"></param>
        /// <param name="founder"></param>
        /// <param name="principal"></param>
        /// <returns></returns>
        Task EditClient(Guid id, string clientName, Guid clientSourceId, string phone, string email, Guid clientTradeId,
            string clientLevel, DateTime nextContactDate, string remarks, string province, string city, string area,
            string detailsAddress, bool clientStatus, string founder, string principal);

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveClient(Guid id);

        /// <summary>
        ///  查询客户
        /// </summary>
        /// <param name="clientName">客户名称</param>
        /// <param name="phone">电话</param>
        /// <param name="email">邮箱</param>
        /// <returns></returns>
        Task<List<ClientDto>> GetClientExam(string clientName, string phone, string email);
    }
}
