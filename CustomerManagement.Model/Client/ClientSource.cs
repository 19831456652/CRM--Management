using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Client
{
    /// <summary>
    ///  客户来源
    /// </summary>
    [Table("Ck_ClientSource")]
    public class ClientSource:BaseEntity
    {
        /// <summary>
        ///   来源名称
        /// </summary>
        [StringLength(50)]
        public string ClientSourceName { get; set; }
    }
}
