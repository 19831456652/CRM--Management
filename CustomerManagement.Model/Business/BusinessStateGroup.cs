using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Business
{
    /// <summary>
    ///  商机状态组
    /// </summary>
    [Table("CK_BusinessStateGroup")]
    public class BusinessStateGroup:BaseEntity
    {
        /// <summary>
        ///  名称
        /// </summary>
        [StringLength(50)]
        public string BusinessStateGroupName { get; set; }

        /// <summary>
        ///  商机状态组
        /// </summary>
        [ForeignKey(nameof(StateGroup))]
        public Guid? BusinessStateGroupId { get; set; }
        public BusinessStateGroup StateGroup { get; set; }
    }
}
