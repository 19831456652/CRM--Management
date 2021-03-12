using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Employees
{
    /// <summary>
    ///  员工
    /// </summary>
    [Table("CM_Employee")]
    public class Employees:BaseEntity
    {
        /// <summary>
        ///  工号
        /// </summary>
        [Required, StringLength(150)]
        public string TheWorkNumber { get; set; }

        /// <summary>
        ///  密码
        /// </summary>
        [Required, StringLength(20)]
        public string Password { get; set; }

        /// <summary>
        ///  名称
        /// </summary>
        [Required, StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        ///  性别
        /// </summary>
        [Required]
        public bool Sex { get; set; }

        /// <summary>
        ///  年龄
        /// </summary>
        [Required]
        public int Age { get; set; }

        /// <summary>
        ///  电话
        /// </summary>
        [Required, StringLength(11)]
        public string Phone { get; set; }


        /// <summary>
        ///  邮箱
        /// </summary>
        [Required, EmailAddress, StringLength(50)]
        public string Email { get; set; }

        /// <summary>
        ///  地址
        /// </summary>
        [StringLength(100)]
        public string Address { get; set; }

        /// <summary>
        ///  头像
        /// </summary>
        [StringLength(120)]
        public string Image { get; set; }

        /// <summary>
        ///  备注
        /// </summary>
        [StringLength(500)]
        public string Remarks { get; set; }

        /// <summary>
        ///  状态 0 可用  1 不可用
        /// </summary>
        [Required]
        public bool Status { get; set; }

        /// <summary>
        ///  部门外键
        /// </summary>

        [ForeignKey(nameof(Branch))]
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
