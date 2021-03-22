using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.ViewModel.Products
{
    /// <summary>
    ///  产品类型视图模型
    /// </summary>
    public class ProductClassifyViewModel
    {
        /// <summary>
        ///  类型名称
        /// </summary>
        [StringLength(50)]
        public string ProductClassifyName { get; set; }
    }
}
