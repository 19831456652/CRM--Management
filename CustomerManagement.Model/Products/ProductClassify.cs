using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Products
{
    /// <summary>
    ///  产品类型
    /// </summary>
    [Table("CK_ProductClassify")]
    public class ProductClassify:BaseEntity
    {
        /// <summary>
        ///  类型名称
        /// </summary>
        [StringLength(50)]
        public string ProductClassifyName { get; set; }
    }
}
