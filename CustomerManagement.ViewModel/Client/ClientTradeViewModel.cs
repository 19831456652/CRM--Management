using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.ViewModel.Client
{
    /// <summary>
    ///  行业名称
    /// </summary>
    public class ClientTradeViewModel
    {/// <summary>
        ///  行业名称
        /// </summary>
        [StringLength(50)]
        public string ClientTradeName { get; set; }
    }
}
