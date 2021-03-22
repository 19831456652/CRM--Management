using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.ViewModel.Contract
{
    /// <summary>
    ///  合同和客户的关系视图模型
    /// </summary>
    public class ContractOfClientViewModel
    {
        /// <summary>
        ///  客户外键
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        ///  合同外键
        /// </summary>
        public Guid ContractId { get; set; }
    }
}
