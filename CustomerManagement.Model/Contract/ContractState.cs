using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Contract
{
    /// <summary>
    ///  合同状态
    /// </summary>
    [Table("CK_ContractState")]
    public class ContractState:BaseEntity
    {
        /// <summary>
        ///  名称
        /// </summary>
        [StringLength(50)]
        public string SContractStateName { get; set; }
    }
}
