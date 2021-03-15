using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// <summary>
        ///  重写实现
        /// </summary>
        /// <param name="branchService"></param>
        public BranchManage(IBranchService branchService)
        {
            _branchService = branchService;
        }

        private readonly IBranchService _branchService;

        public async Task<List<BranchDto>> GetAllBranch()
        {
            return await _branchService.GetAllAsync().Select(i => new BranchDto()
            {
                BranchName = i.BranchName
            }).ToListAsync();
        }

        public async Task CrateData(string branchName)
        {
            await _branchService.CreateAsync(new Model.Employees.Branch()
            {
                BranchName = branchName
            });
        }
    }
}
