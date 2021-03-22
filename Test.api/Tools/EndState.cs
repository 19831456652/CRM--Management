using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.api.Tools
{
    /// <summary>
    ///  结束状态
    /// </summary>
    public class EndState
    {
        /// <summary>
        /// 状态编号
        /// </summary>
        public int Code { get; set; } = 200;
        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool IsSucceed { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
