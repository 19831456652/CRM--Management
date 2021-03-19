using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Contract
{
    /// <summary>
    ///  合同类型
    /// </summary>
    [Table("CK_ContractClassify")]
    public class ContractClassify:BaseEntity
    {
        /// <summary>
        ///  合同类型名称
        /// </summary>
        [StringLength(50)]
        public string ProductUnitName { get; set; }
    }
}
