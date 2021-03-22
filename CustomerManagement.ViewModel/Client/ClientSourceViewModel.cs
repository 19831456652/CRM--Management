using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.ViewModel.Client
{
    /// <summary>
    ///  客户来源视图模型
    /// </summary>
    public class ClientSourceViewModel
    {
        /// <summary>
        ///   来源名称
        /// </summary>
        [StringLength(50)]
        public string ClientSourceName { get; set; }
    }
}
