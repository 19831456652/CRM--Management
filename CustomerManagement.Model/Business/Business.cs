using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CustomerManagement.Model.Products;

namespace CustomerManagement.Model.Business
{
    /// <summary>
    ///  商机
    /// </summary>
    [Table("CK_Business")]
    public class Business:BaseEntity
    {
        /// <summary>
        ///  商机名称
        /// </summary>
        [StringLength(50)]
        public string BusinessName { get; set; }

        // 客户外键
        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client.Client Client { get; set; }

        /// <summary>
        ///  商机金额
        /// </summary>
        public decimal BusinessMoney { get; set; }

        /// <summary>
        ///  预计成交时间
        /// </summary>
        public DateTime ExpectedDate { get; set; } = DateTime.Now.Date;

        /// <summary>
        ///  商机状态
        /// </summary>
        [StringLength(100)]
        public string BusinessStateGroup { get; set; }

        /// <summary>
        ///  商机阶段
        /// </summary>
        [StringLength(20)]
        public string BusinessStage { get; set; }

        /// <summary>
        ///  备注
        /// </summary>
        [StringLength(200)]
        public string Remarks { get; set; }

        /// <summary>
        ///  产品信息
        /// </summary>
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

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
