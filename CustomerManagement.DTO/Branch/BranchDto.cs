using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.DTO.Branch
{
    /// <summary>
    ///  部门 DTO
    /// </summary>
    public class BranchDto
    {
        /// <summary>
        ///  部门编号
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        ///  部门名称
        /// </summary>
        public string BranchName { get; set; }
    }
}
