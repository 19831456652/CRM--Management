using System;

namespace CustomerManagement.Model
{
    /// <summary>
    ///  公共类
    /// </summary>
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // 创建时间 默认为当前时间
        public DateTime CreateDate { get; set; } = DateTime.Now;

        // 更新时间 默认为当前时间
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        // 是否删除
        public bool IsRemove { get; set; }
    }
}
