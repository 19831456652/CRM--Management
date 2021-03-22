using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.ViewModel.Contract
{
    /// <summary>
    ///  合同视图模型
    /// </summary>
    public class ContractViewModel
    {
        /// <summary>
        ///  合同编号
        /// </summary>
        [StringLength(50)]
        public string ContractCoding { get; set; }


        /// <summary>
        ///  合同名称
        /// </summary>
        [StringLength(50)]
        public string ContractName { get; set; }

        /// <summary>
        ///  合同金额
        /// </summary>
        public decimal ContractMoney { get; set; }

        /// <summary>
        ///  下单时间
        /// </summary>
        public DateTime PlaceanorderDate { get; set; } = DateTime.Now.Date;

        /// <summary>
        ///  合同开始时间
        /// </summary>
        public DateTime ContractStart { get; set; } = DateTime.Now.Date;

        /// <summary>
        ///  合同结束时间
        /// </summary>
        public DateTime Contractend { get; set; } = DateTime.Now.Date;

        /// <summary>
        ///  合同签约人
        /// </summary>
        [StringLength(50)]
        public string CompanySignatory { get; set; }

        /// <summary>
        ///  备注
        /// </summary>
        [StringLength(100)]
        public string Remarks { get; set; }

        /// <summary>
        ///  合同类型
        /// </summary>
        public Guid ContractClassifyId { get; set; }

        /// <summary>
        ///  合同状态
        /// </summary>
        public bool ContractState { get; set; }

        /// <summary>
        ///  产品信息
        /// </summary>
        public Guid ProductId { get; set; }

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
