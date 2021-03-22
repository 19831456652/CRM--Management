using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.IDAL.IClient;
using CustomerManagement.Model;
using CustomerManagement.Model.Client;

namespace CustomerManagement.DAL.Client
{
    /// <summary>
    ///  实现客户状态  DAL
    /// </summary>
    public class ClientStatusService:BaseService<ClientStatus>,IClientStatusService
    {
        public ClientStatusService() : base(new CustomerManagementContext())
        {

        }
    }
}
