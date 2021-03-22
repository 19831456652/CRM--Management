using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerManagement.DTO.Employees;

namespace CustomerManagement.IBLL.IEmployees
{
    /// <summary>
    ///  员工 IBLL 功能接口
    /// </summary>
    public interface IEmployeesManage
    {
        // 注册 
        Task Register(string theWorkNumber, string password, string uName, bool sex, int age, string phone, string email, string address, string image, string remarks, bool status, Guid branchId);

        // 登录
        bool Login(string email, string password, out Guid userId);
        // 获取所有用户
        Task<List<EmployeesDto>> GetAllEmployees();

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id"></param>
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
        Task EditEmp(Guid id, string password, string uName, bool sex, int age, string phone, string email, string address, string image, string remarks, bool status, Guid branchId);

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveEmp(Guid id);
    }
}
