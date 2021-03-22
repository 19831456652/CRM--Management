using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.IDAL.IClient;
using CustomerManagement.Model;
using CustomerManagement.Model.Client;

namespace CustomerManagement.DAL.Client
{
    /// <summary>
    ///  实现客户行业  DAL
    /// </summary>
    public class ClientTradeService:BaseService<ClientTrade>,IClientTradeService
    {
        public ClientTradeService() : base(new CustomerManagementContext())
        {

        }
    }
}
