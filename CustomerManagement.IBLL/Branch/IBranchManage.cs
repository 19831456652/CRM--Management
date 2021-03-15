using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DTO.Branch;

namespace CustomerManagement.IBLL.Branch
{
    /// <summary>
    ///  部门功能接口 IBLL
    /// </summary>
    public interface IBranchManage
    {
        /// <summary>
        ///  获取所有部门
        /// </summary>
        /// <returns></returns>
        Task<List<BranchDto>> GetAllBranch();

        /// <summary>
        ///  添加
        /// </summary>
        /// <param name="branchName"></param>
        /// <returns></returns>
        Task CrateData(string branchName);
    }
}
