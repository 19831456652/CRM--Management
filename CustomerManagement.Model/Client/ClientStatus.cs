using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Client
{
    /// <summary>
    ///  客户状态
    /// </summary>
    [Table("CK_ClientStatus")]
    public class ClientStatus:BaseEntity
    {
        /// <summary>
        ///  状态名称
        /// </summary>
        public string ClientStatusName { get; set; }
    }
}
