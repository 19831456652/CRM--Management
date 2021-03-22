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
using Microsoft.VisualBasic;

namespace CustomerManagement.BLL.Employees
{
    public class EmployeesManage:IEmployeesManage
    {

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
            using IEmployeesService employeesService = new EmployeesService();
            await employeesService.CreateAsync(new Model.Employees.Employees()
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
            using IEmployeesService employeesService = new EmployeesService();
            var use = employeesService.GetAllAsync().FirstOrDefault(s => s.Email == email && s.Password == password);
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
            using IEmployeesService employeesService = new EmployeesService();
            return await employeesService.GetAllAsync().Select(i => new EmployeesDto()
            {
                Id = i.Id,
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

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="password">密码</param>
        /// <param name="uName">名称</param>
        /// <param name="sex">性别</param>
        /// <param name="age">年龄</param>
        /// <param name="phone">手机号</param>
        /// <param name="email">邮箱</param>
        /// <param name="address">地址</param>
        /// <param name="image">头像</param>
        /// <param name="remarks">备注</param>
        /// <param name="status">状态</param>
        /// <param name="branchId">部门</param>
        /// <returns></returns>
        public async Task EditEmp(Guid id, string password, string uName, bool sex, int age, string phone, string email, string address,
            string image, string remarks, bool status, Guid branchId)
        {

            using IEmployeesService employeesService = new EmployeesService();
            if (await employeesService.GetAllAsync().AnyAsync(i => i.Id == id))
            {
                var emp = employeesService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (emp != null)
                {
                    emp.Password = password;
                    emp.Name = uName;
                    emp.Sex = sex;
                    emp.Age = age;
                    emp.Phone = phone;
                    emp.Email = email;
                    emp.Address = address;
                    emp.Image = image;
                    emp.Remarks = remarks;
                    emp.Status = status;
                    emp.BranchId = branchId;
                }
                await employeesService.EditAsync(emp);
            }
            
            
        }

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id">员工id</param>
        /// <returns></returns>
        public async Task RemoveEmp(Guid id)
        {
            using IEmployeesService employeesService = new EmployeesService();
            if (await employeesService.GetAllAsync().AnyAsync(i=>i.Id == id))
            {
                var emp = employeesService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (emp != null)
                {
                    await employeesService.RemoveAsync(id);
                }
            }
        }
    }
}
