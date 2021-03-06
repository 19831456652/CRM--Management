using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.ViewModel.Employee
{
    public class MenuAllViewModel
    {


        /// <summary>
        ///  名称
        /// </summary>
        [StringLength(100)]
        public string Title { get; set; }

        /// <summary>
        ///  菜单图标
        /// </summary>
        [StringLength(20)]
        public string Image { get; set; }


        /// <summary>
        ///  父级菜单
        /// </summary>
        public Guid MMenuId { get; set; }

        /// <summary>
        ///  菜单名称
        /// </summary>
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        ///  页面名称
        /// </summary>
        [StringLength(100)]
        public string Path { get; set; }


        /// <summary>
        ///  页面路径
        /// </summary>
        [StringLength(120)]
        public string View { get; set; }


        /// <summary>
        /// 菜单状态
        /// </summary>
        public bool MenuState { get; set; }
    }
}
