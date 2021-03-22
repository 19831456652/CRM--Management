using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DAL.Employees;
using CustomerManagement.DTO.Branch;
using CustomerManagement.IBLL.Branch;
using CustomerManagement.IDAL.IEmployees;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.BLL.Branch
{
    /// <summary>
    ///  部门实现功能 BLL
    /// </summary>
    public class BranchManage:IBranchManage
    {
        // private readonly IBranchService _branchService;
        // /// <summary>
        // ///  重写实现
        // /// </summary>
        // /// <param name="branchService"></param>
        // public BranchManage(IBranchService branchService)
        // {
        //     _branchService = branchService;
        // }

        public async Task<List<BranchDto>> GetAllBranch()
        {
            using BranchService branchService = new BranchService();
            return await branchService.GetAllAsync().Select(i => new BranchDto()
            {
                BranchId = i.Id,
                BranchName = i.BranchName
            }).ToListAsync();
        }

        // /// <summary>
        // ///  获取所有部门信息不用异步
        // /// </summary>
        // /// <returns></returns>
        // public List<BranchDto> GetAll()
        // {
        //     List<BranchDto> list = _branchService.GetAll().Select(i => new BranchDto()
        //     {
        //         BranchId = i.Id,
        //         BranchName = i.BranchName
        //     }).ToList();
        //     return list;
        // }

        public async Task CrateData(string branchName)
        {
            using BranchService branchService = new BranchService();
            await branchService.CreateAsync(new Model.Employees.Branch()
            {
                BranchName = branchName
            });
        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id">部门id</param>
        /// <param name="branchName">部门名称</param>
        /// <returns></returns>
        public async Task EditBranch(Guid id, string branchName)
        {
            using BranchService branchService = new BranchService();
            if (await branchService.GetAllAsync().AnyAsync(i=>i.Id == id))
            {
                var branch = branchService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (branch != null)
                {
                    branch.BranchName = branchName;
                }
                await branchService.EditAsync(branch);
            }
            

        }

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id">部门id</param>
        /// <returns></returns>
        public async Task RemoveBranch(Guid id)
        {
            using BranchService branchService = new BranchService();
            if (await branchService.GetAllAsync().AnyAsync(i => i.Id == id))
            {
                var branch = branchService.GetAllAsync().FirstOrDefault(i => i.Id == id);
                if (branch != null)
                {
                    await branchService.RemoveAsync(branch);
                }
            }
        }
    }
}
