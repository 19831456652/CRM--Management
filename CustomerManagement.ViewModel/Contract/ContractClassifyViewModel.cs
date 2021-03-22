using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.ViewModel.Contract
{
    /// <summary>
    ///  合同类型视图模型
    /// </summary>
    public class ContractClassifyViewModel
    {
        /// <summary>
        ///  合同类型名称
        /// </summary>
        [StringLength(50)]
        public string ProductUnitName { get; set; }
    }
}
