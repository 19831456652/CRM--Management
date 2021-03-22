using System;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Model;

namespace CustomerManagement.IDAL
{
    /// <summary>
    ///  功能接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseService<T>: IDisposable where T:BaseEntity
    {
        /// <summary>
        ///  添加
        /// </summary>
        /// <param name="model">参数</param>  
        /// <param name="saved"></param>
        /// <returns></returns>
        Task CreateAsync(T model, bool saved = true);

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="model">参数</param>
        /// <param name="saved"></param>
        /// <returns></returns>
        Task EditAsync(T model, bool saved = true);


        /// <summary>
        ///  根据id删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <returns></returns>
        Task RemoveAsync(Guid id, bool saved = true);

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="model"></param>
        /// <param name="saved"></param>
        /// <returns></returns>
        Task RemoveAsync(T model, bool saved = true);


        /// <summary>
        ///  保存
        /// </summary>
        /// <returns></returns>
        Task Save();

        /// <summary>
        ///  根据id获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetOneByIdAsync(Guid id);


        // Task<T> GetAllEmail(string email);

        /// <summary>
        ///  获取全部数据
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAllAsync();

        // IQueryable<T> GetAll();

        /// <summary>
        ///  获取数据并分页
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        IQueryable<T> GetAllPageAsync(int pageSize = 10, int pageIndex = 0);

        /// <summary>
        ///  获取数据并排序
        /// </summary>
        /// <param name="asc"></param>
        /// <returns></returns>
        IQueryable<T> GetAllOrderAsync(bool asc = true);

        /// <summary>
        ///  获取数据并排序分页
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        IQueryable<T> GetAllByPageOrderAsync(int pageSize = 10, int pageIndex = 0, bool asc = true);

    }
}
