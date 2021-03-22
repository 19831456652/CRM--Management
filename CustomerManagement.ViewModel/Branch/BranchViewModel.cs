using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.ViewModel.Branch
{
    /// <summary>
    ///  部门视图模型
    /// </summary>
    public class BranchViewModel
    {
        /// <summary>
        ///  部门名称
        /// </summary>
        [StringLength(50)]
        public string BranchName { get; set; }
    }
}
