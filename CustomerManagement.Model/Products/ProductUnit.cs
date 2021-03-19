using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Products
{
    /// <summary>
    ///  产品单位
    /// </summary>
    [Table("CK_ProductUnit")]
    public class ProductUnit:BaseEntity
    {
        /// <summary>
        ///  名称
        /// </summary>
        [StringLength(20)]
        public string ProductUnitName { get; set; }
    }
}
