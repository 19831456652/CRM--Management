using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Client
{
    /// <summary>
    ///  客户级别
    /// </summary>
    [Table("Ck_ClientLevel")]
    public class ClientLevel:BaseEntity
    {
        /// <summary>
        ///  级别名称
        /// </summary>
        [StringLength(50)]
        public string ClientLevelName { get; set; }
    }
}
