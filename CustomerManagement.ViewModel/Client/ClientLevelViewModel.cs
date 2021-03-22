using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.ViewModel.Client
{
    /// <summary>
    ///  客户级别视图模型
    /// </summary>
    public class ClientLevelViewModel
    {
        /// <summary>
        ///  级别名称
        /// </summary>
        [StringLength(50)]
        public string ClientLevelName { get; set; }
    }
}
