using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Client
{
    /// <summary>
    ///  客户行业
    /// </summary>
    [Table("Ck_ClientTrade")]
    public class ClientTrade:BaseEntity
    {
        /// <summary>
        ///  行业名称
        /// </summary>
        [StringLength(50)]
        public string ClientTradeName { get; set; }
    }
}
