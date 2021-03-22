using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.ViewModel.Contract
{
    /// <summary>
    ///  合同状态视图模型
    /// </summary>
    public class ContractOfStateViewModel
    {
        /// <summary>
        ///  名称
        /// </summary>
        [StringLength(50)]
        public string SContractStateName { get; set; }
    }
}
