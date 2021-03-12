using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerManagement.ViewModel.Employee
{
    /// <summary>
    ///  登录视图模型
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        ///  邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///  密码
        /// </summary>
        [Required, DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}
