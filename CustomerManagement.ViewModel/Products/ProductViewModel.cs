using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.ViewModel.Products
{
    /// <summary>
    ///  产品视图模型
    /// </summary>
    public class ProductViewModel
    {
        /// <summary>
        ///  产品名称
        /// </summary>
        [StringLength(20)]
        public string ProductName { get; set; }

        /// <summary>
        ///  类型外键
        /// </summary>
        public Guid ProductClassifyId { get; set; }

        /// <summary>
        ///  产品单位
        /// </summary>
        public Guid ProductUnitId { get; set; }

        /// <summary>
        ///  产品编码
        /// </summary>
        [StringLength(50)]
        public string ProductCoding { get; set; }

        /// <summary>
        ///  产品价格
        /// </summary>
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [StringLength(200)]
        public string ProductDescription { get; set; }

        /// <summary>
        ///  是否上下架 0 上架  1 下架
        /// </summary>
        public bool Whetheronorofftheshelf { get; set; }

        /// <summary>
        ///  产品图片
        /// </summary>
        public string ProductImage { get; set; }

        /// <summary>
        ///  产品详情图片
        /// </summary>
        public string ProductDetailsImage { get; set; }

        /// <summary>
        ///  产品数量
        /// </summary>
        public int ProductQuantity { get; set; }

        /// <summary>
        ///  销售价格
        /// </summary>
        public decimal SellingPrice { get; set; }

        /// <summary>
        ///  产品合计
        /// </summary>
        public decimal ProductTotal { get; set; }

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
