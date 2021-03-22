using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.ViewModel.Contact
{
    /// <summary>
    ///  联系人视图模型
    /// </summary>
    public class ContactPersonViewModel
    {
        /// <summary>
        ///  联系人姓名
        /// </summary>
        [StringLength(50)]
        public string ContactPersonName { get; set; }

        // 客户外键
        public Guid ClientId { get; set; }

        /// <summary>
        ///  电话
        /// </summary>
        [StringLength(11)]
        public string Phone { get; set; }

        /// <summary>
        ///  邮箱
        /// </summary>
        [StringLength(20), EmailAddress]
        public string Email { get; set; }

        /// <summary>
        ///  职务
        /// </summary>
        [StringLength(20)]
        public string Post { get; set; }

        /// <summary>
        ///  是否是决策人 0 是 1 否
        /// </summary>
        public bool DecisionMaker { get; set; }

        /// <summary>
        ///  地址
        /// </summary>
        [StringLength(20)]
        public string Address { get; set; }

        /// <summary>
        ///  下次联系时间
        /// </summary>
        public DateTime NextcontactDate { get; set; } = DateTime.Now.Date;

        /// <summary>
        ///  备注
        /// </summary>
        [StringLength(200)]
        public string Remarks { get; set; }

        /// <summary>
        ///  性别
        /// </summary>
        public bool Sex { get; set; }

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
