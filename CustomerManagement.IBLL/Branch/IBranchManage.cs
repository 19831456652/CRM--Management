using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.DTO.Branch;
using Microsoft.IdentityModel.Tokens;

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

        // List<BranchDto> GetAll();

        /// <summary>
        ///  添加
        /// </summary>
        /// <param name="branchName"></param>
        /// <returns></returns>
        Task CrateData(string branchName);

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="branchName"></param>
        /// <returns></returns>
        Task EditBranch(Guid id, string branchName);

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveBranch(Guid id);
    }
}
