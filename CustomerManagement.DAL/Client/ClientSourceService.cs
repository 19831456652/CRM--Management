using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.IDAL.IClient;
using CustomerManagement.Model;
using CustomerManagement.Model.Client;

namespace CustomerManagement.DAL.Client
{
    /// <summary>
    ///  实现客户来源  DAL
    /// </summary>
    public class ClientSourceService:BaseService<ClientSource>,IClientSourceService
    {
        public ClientSourceService() : base(new CustomerManagementContext())
        {

        }
    }
}
