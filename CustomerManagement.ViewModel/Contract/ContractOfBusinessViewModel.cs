using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.ViewModel.Contract
{
    /// <summary>
    ///  合同商机关系模型
    /// </summary>
    public class ContractOfBusinessViewModel
    {
        /// <summary>
        ///  商机外键
        /// </summary>
        public Guid BusinessId { get; set; }

        /// <summary>
        ///  合同外键
        /// </summary>
        public Guid ContractId { get; set; }
    }
}
