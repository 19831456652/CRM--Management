using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.IDAL;
using CustomerManagement.IDAL.IClient;
using CustomerManagement.Model;

namespace CustomerManagement.DAL.Client
{
    /// <summary>
    ///  实现客户  DAL
    /// </summary>
    public class ClientService:BaseService<Model.Client.Client>,IClientService
    {
        public ClientService() : base(new CustomerManagementContext())
        {

        }
    }
}
