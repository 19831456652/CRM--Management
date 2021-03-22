using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.IDAL.IClient;
using CustomerManagement.Model;
using CustomerManagement.Model.Client;

namespace CustomerManagement.DAL.Client
{
    /// <summary>
    ///  实现客户级别 DAL
    /// </summary>
    public class ClientLevelService:BaseService<ClientLevel>,IClientLevelService
    {
        public ClientLevelService() : base(new CustomerManagementContext())
        {

        }
    }
}
