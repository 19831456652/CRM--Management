using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Contract
{
    /// <summary>
    ///  合同和客户的关系表
    /// </summary>
    [Table("CK_ContractOfClient")]
    public class ContractOfClient:BaseEntity
    {
        /// <summary>
        ///  客户外键
        /// </summary>
        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client.Client Client { get; set; }

        /// <summary>
        ///  合同外键
        /// </summary>
        [ForeignKey(nameof(Contract))]
        public Guid ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
