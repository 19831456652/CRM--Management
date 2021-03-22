using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.ViewModel.Contract
{
    /// <summary>
    ///  
    /// </summary>
    public class ContractOrContactPersonViewModel
    {
        /// <summary>
        ///  联系人外键
        /// </summary>
        public Guid ContactPersonId { get; set; }



        /// <summary>
        ///  合同外键
        /// </summary>
        public Guid ContractId { get; set; }
    }
}
