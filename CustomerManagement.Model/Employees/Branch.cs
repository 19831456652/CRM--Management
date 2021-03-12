using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Model.Employees
{
    /// <summary>
    ///  部门
    /// </summary>
    [Table("CM_Branch")]
    public class Branch:BaseEntity
    {
        /// <summary>
        ///  部门名称
        /// </summary>
        [StringLength(50)]
        public string BranchName { get; set; }
    }
}
