using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Contract
{
    /// <summary>
    ///  合同商机关系表
    /// </summary>
    [Table("CK_ContractOfBusiness")]
    public class ContractOfBusiness
    {
        /// <summary>
        ///  商机外键
        /// </summary>
        [ForeignKey(nameof(Business))]
        public Guid BusinessId { get; set; }
        public Business.Business Business { get; set; }

        /// <summary>
        ///  合同外键
        /// </summary>
        [ForeignKey(nameof(Contract))]
        public Guid ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
