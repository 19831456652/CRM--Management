using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CustomerManagement.Model.Contact;

namespace CustomerManagement.Model.Contract
{
    /// <summary>
    ///  合同联系人关系表
    /// </summary>
    [Table("CK_ContractOfContactPerson")]
    public class ContractOfContactPerson
    {
        /// <summary>
        ///  联系人外键
        /// </summary>
        [ForeignKey(nameof(ContactPerson))]
        public Guid ContactPersonId { get; set; }
        public ContactPerson ContactPerson { get; set; }




        /// <summary>
        ///  合同外键
        /// </summary>
        [ForeignKey(nameof(Contract))]
        public Guid ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
