using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DAL.Client;
using CustomerManagement.DTO.Client;
using CustomerManagement.IBLL.Client;
using CustomerManagement.IDAL.IClient;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.BLL.Client
{
    public class ClientManage:IClientManage
    {
        /// <summary>
        ///  添加客户
        /// </summary>
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
        public async Task Register(string clientName, Guid clientSourceId, string phone, string email, Guid clientTradeId,
            string clientLevel, DateTime nextContactDate, string remarks, string province, string city, string area,
            string detailsAddress, bool clientStatus, string founder, string principal)
        {
            using IClientService clientService = new ClientService();
            await clientService.CreateAsync(new Model.Client.Client()
            {
                ClientName = clientName,
                ClientSourceId = clientSourceId,
                Phone = phone,
                Email = email,
                ClientTradeId = clientTradeId,
                ClientLevel = clientLevel,
                NextContactDate = nextContactDate,
                Remarks = remarks,
                Province = province,
                City = city,
                Area = area,
                DetailsAddress = detailsAddress,
                ClientStatus = clientStatus,
                Founder = founder,
                Principal = principal
            });
        }


        /// <summary>
        ///  获取所有数据
        /// </summary>
        /// <returns></returns>
        public async Task<List<ClientDto>> GetAllClient()
        {
            using IClientService clientService = new ClientService();
            return await clientService.GetAllAsync().Select(i => new ClientDto()
            {
                ClientName = i.ClientName,
                ClientSourceId = i.ClientSourceId,
                Phone = i.Phone,
                Email = i.Email,
                ClientTradeId = i.ClientTradeId,
                ClientLevel = i.ClientLevel,
                NextContactDate = i.NextContactDate,
                Remarks = i.Remarks,
                Province = i.Province,
                City = i.City,
                Area = i.Area,
                DetailsAddress = i.DetailsAddress,
                ClientStatus = i.ClientStatus,
                Founder = i.Founder,
                Principal = i.Principal
            }).ToListAsync();
        }

        
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
        public async Task EditClient(Guid id, string clientName, Guid clientSourceId, string phone, string email, Guid clientTradeId,
            string clientLevel, DateTime nextContactDate, string remarks, string province, string city, string area,
            string detailsAddress, bool clientStatus, string founder, string principal)
        {
            using IClientService clientService = new ClientService();
            if (await clientService.GetAllAsync().AnyAsync(i=>i.Id == id))
            {
                var client = clientService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (client != null)
                {
                    client.ClientName = clientName;
                    client.ClientSourceId = clientSourceId;
                    client.Phone = phone;
                    client.Email = email;
                    client.ClientTradeId = clientTradeId;
                    client.ClientLevel = clientLevel;
                    client.NextContactDate = nextContactDate;
                    client.Remarks = remarks;
                    client.Province = province;
                    client.City = city;
                    client.Area = area;
                    client.DetailsAddress = detailsAddress;
                    client.ClientStatus = clientStatus;
                    client.Founder = founder;
                    client.Principal = principal;
                }
                await clientService.EditAsync(client);
            }
            
        }

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task RemoveClient(Guid id)
        {
            using IClientService clientService = new ClientService();
            if (await clientService.GetAllAsync().AnyAsync(i => i.Id == id))
            {
                var client = clientService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (client != null)
                {
                    await clientService.RemoveAsync(client);
                }
            }
        }

        /// <summary>
        ///  根据客户名称电话邮箱获取数据
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<List<ClientDto>> GetClientExam(string clientName, string phone, string email)
        {
            using IClientService clientService = new ClientService();
            return await clientService.GetAllAsync()
                .Where(i => i.ClientName == clientName || i.Phone == phone || i.Email == email).Select(c =>
                    new ClientDto()
                    {
                        ClientName = c.ClientName,
                        ClientSourceId = c.ClientSourceId,
                        Phone = c.Phone,
                        Email = c.Email,
                        ClientTradeId = c.ClientTradeId,
                        ClientLevel = c.ClientLevel,
                        NextContactDate = c.NextContactDate,
                        Remarks = c.Remarks,
                        Province = c.Province,
                        City = c.City,
                        Area = c.Area,
                        DetailsAddress = c.DetailsAddress,
                        ClientStatus = c.ClientStatus,
                        Founder = c.Founder,
                        Principal = c.Principal
                    }).ToListAsync();
            
        }
    }
}
