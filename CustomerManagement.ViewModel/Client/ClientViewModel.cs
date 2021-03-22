using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.ViewModel.Client
{
    /// <summary>
    ///  客户视图模型
    /// </summary>
    public class ClientViewModel
    {
        /// <summary>
        ///  客户名称
        /// </summary>
        [StringLength(50)]
        public string ClientName { get; set; }


        /// <summary>
        ///  客户来源
        /// </summary>
        public Guid ClientSourceId { get; set; }

        /// <summary>
        ///  电话
        /// </summary>
        [StringLength(11)]
        public string Phone { get; set; }

        /// <summary>
        ///  邮箱
        /// </summary>
        [StringLength(100), EmailAddress]
        public string Email { get; set; }

        /// <summary>
        ///  客户行业
        /// </summary>
        public Guid ClientTradeId { get; set; }

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
