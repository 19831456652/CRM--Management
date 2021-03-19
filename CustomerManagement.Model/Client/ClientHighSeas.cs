using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Client
{
    /// <summary>
    ///  客户公海
    /// </summary>
    [Table("CK_ClientHighSeas")]
    public class ClientHighSeas:BaseEntity
    {
        /// <summary>
        ///  客户名称
        /// </summary>
        [StringLength(50)]
        public string ClientName { get; set; }

        /// <summary>
        ///  电话
        /// </summary>
        [StringLength(11)]
        public string Phone { get; set; }

        /// <summary>
        ///  下次联系时间
        /// </summary>
        public DateTime NextContactDate { get; set; } = DateTime.Now.Date;

        /// <summary>
        ///  备注
        /// </summary>
        [StringLength(500)]
        public string Remarks { get; set; }

        /// <summary>
        ///  客户级别 
        /// </summary>
        [StringLength(50)]
        public string ClientLevel { get; set; }

        /// <summary>
        ///  客户来源 （外键）
        /// </summary>
        [ForeignKey(nameof(ClientSource))]
        public Guid ClientSourceId { get; set; }
        public ClientSource ClientSource { get; set; }

        /// <summary>
        ///  客户行业（外键）
        /// </summary>
        [ForeignKey(nameof(ClientTrade))]
        public Guid ClientTradeId { get; set; }
        public ClientTrade ClientTrade { get; set; }

        /// <summary>
        ///  客户成交状态 0 已成交 1 未成交 
        /// </summary>
        public bool ClientStatus { get; set; }

        /// <summary>
        ///  最后一次跟进时间
        /// </summary>
        public DateTime AtLastFollowDateTime { get; set; } = DateTime.Now.Date;
    }
}
