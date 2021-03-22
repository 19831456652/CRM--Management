using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.IDAL.IClient;
using CustomerManagement.Model;
using CustomerManagement.Model.Client;

namespace CustomerManagement.DAL.Client
{
    /// <summary>
    ///  实现客户公海  DAL
    /// </summary>
    public class ClientHighSeasService:BaseService<ClientHighSeas>,IClientHighSeasService
    {
        public ClientHighSeasService() : base(new CustomerManagementContext())
        {

        }
    }
}
