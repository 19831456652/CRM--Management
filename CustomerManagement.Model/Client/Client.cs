using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CustomerManagement.Model.Enumerate;

namespace CustomerManagement.Model.Client
{
    /// <summary>
    ///  客户
    /// </summary>
    [Table("Ck_Client")]
    public class Client:BaseEntity
    {
        /// <summary>
        ///  客户名称
        /// </summary>
        [StringLength(50)]
        public string ClientName { get; set; }


        /// <summary>
        ///  客户来源 （外键）
        /// </summary>
        [ForeignKey(nameof(ClientSource))]
        public Guid ClientSourceId { get; set; }
        public ClientSource ClientSource { get; set; }

        /// <summary>
        ///  电话
        /// </summary>
        [StringLength(11)]
        public string Phone { get; set; }

        /// <summary>
        ///  邮箱
        /// </summary>
        [StringLength(100),EmailAddress]
        public string Email { get; set; }

        /// <summary>
        ///  客户行业（外键）
        /// </summary>
        [ForeignKey(nameof(ClientTrade))]
        public Guid ClientTradeId { get; set; }
        public ClientTrade ClientTrade { get; set; }

        /// <summary>
        ///  客户级别 
        /// </summary>
        [StringLength(50)]
        public string ClientLevel { get; set; }

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
        ///  省
        /// </summary>
        [StringLength(50)]
        public string Province { get; set; }

        /// <summary>
        ///  市
        /// </summary>
        [StringLength(50)]
        public string City { get; set; }

        /// <summary>
        ///  区
        /// </summary>
        [StringLength(50)]
        public string Area { get; set; }

        /// <summary>
        ///  详情地址
        /// </summary>
        [StringLength(150)]
        public string DetailsAddress { get; set; }

        /// <summary>
        ///  客户成交状态 0 已成交 1 未成交 
        /// </summary>
        public bool ClientStatus { get; set; }

        /// <summary>
        ///  创建人
        /// </summary>
        [StringLength(50)]
        public string Founder { get; set; }

        /// <summary>
        ///  负责人
        /// </summary>
        [StringLength(50)]
        public string Principal { get; set; }

    }
}
