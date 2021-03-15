using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DAL.Employees;
using CustomerManagement.DTO.Employees;
using CustomerManagement.IBLL.IEmployees;
using CustomerManagement.IDAL.IEmployees;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.BLL.Employees
{
    public class EmployeesManage:IEmployeesManage
    {

        public EmployeesManage(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        private readonly IEmployeesService _employeesService;

        /// <summary>
        ///  注册
        /// </summary>
        /// <param name="theWorkNumber"></param>
        /// <param name="password"></param>
        /// <param name="uName"></param>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="address"></param>
        /// <param name="image"></param>
        /// <param name="remarks"></param>
        /// <param name="status"></param>
        /// <param name="branchId"></param>
        /// <returns></returns>

        public async Task Register(string theWorkNumber, string password, string uName, bool sex, int age, string phone, string email,
            string address, string image, string remarks, bool status, Guid branchId)
        {
            await _employeesService.CreateAsync(new Model.Employees.Employees()
            {
                TheWorkNumber = theWorkNumber,
                Password = password,
                Name = uName,
                Sex = sex,
                Age = age,
                Phone = phone,
                Email = email,
                Address = address,
                Image = image,
                Remarks = remarks,
                Status = status,
                BranchId = branchId
            });
        }

        /// <summary>
        ///  登录
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Login(string email, string password, out Guid userId)
        {
            var use = _employeesService.GetAllAsync().First(s => s.Email == email && s.Password == password);
            if (use != null)
            {
                userId = use.Id;
                return true;
            }
            else
            {
                userId = new Guid();
                return false;
            }
        }

        /// <summary>
        ///  获取所有员工信息
        /// </summary>
        /// <returns></returns>
        public async Task<List<EmployeesDto>> GetAllEmployees()
        {
            using IEmployeesService userServer = new EmployeesService();
            return await userServer.GetAllAsync().Select(i => new EmployeesDto()
            {
                TheWorkNumber = i.TheWorkNumber,
                Password = i.Password,
                UName = i.Name,
                Sex = i.Sex,
                Age = i.Age,
                Phone = i.Phone,
                Email = i.Email,
                Address = i.Address,
                Image = i.Image,
                Remarks = i.Remarks,
                Status = i.Status,
                BranchId = i.BranchId,
            }).ToListAsync();

        }
    }
}
