using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.ViewModel.Products
{
    /// <summary>
    ///  产品类型视图模型
    /// </summary>
    public class ProductUnitViewModel
    {
        /// <summary>
        ///  名称
        /// </summary>
        [StringLength(20)]
        public string ProductUnitName { get; set; }
    }
}
