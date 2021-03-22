using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.ViewModel.Business
{
    /// <summary>
    ///  商机状态视图模型
    /// </summary>
    public class BusinessStateGroupViewModel
    {
        /// <summary>
        ///  名称
        /// </summary>
        [StringLength(50)]
        public string BusinessStateGroupName { get; set; }

        /// <summary>
        ///  商机状态组
        /// </summary>
        public Guid? BusinessStateGroupId { get; set; }
    }
}
