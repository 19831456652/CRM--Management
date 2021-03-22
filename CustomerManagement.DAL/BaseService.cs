using System;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using CustomerManagement.IDAL;
using CustomerManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.DAL
{
    public class BaseService<T>:IBaseService<T> where T:BaseEntity,new()
    {

        private readonly CustomerManagementContext _managementContext;
        protected BaseService(CustomerManagementContext customerManagementContext)
        {
            _managementContext = customerManagementContext;
        }

        /// <summary>
        ///  添加
        /// </summary>
        /// <param name="model"></param>
        /// <param name="saved"></param>
        /// <returns></returns>
        public async Task CreateAsync(T model, bool saved = true)
        {
            await _managementContext.Set<T>().AddAsync(model);
            if (saved)
            {
                await _managementContext.SaveChangesAsync();
            }

        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="model"></param>
        /// <param name="saved"></param>
        /// <returns></returns>
        public async Task EditAsync(T model, bool saved = true)
        {
            _managementContext.Entry(model).State = EntityState.Modified;
            if (saved)
            {
                await _managementContext.SaveChangesAsync();
            }
        }
        
        

        /// <summary>
        ///  根据 id 删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <returns></returns>
        public async Task RemoveAsync(Guid id, bool saved = true)
        {
            var t = new T() { Id = id };
            _managementContext.Entry(t).State = EntityState.Unchanged;
            t.IsRemove = true;
            if (saved)
            {
                await _managementContext.SaveChangesAsync();
            }
        }
        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="model"></param>
        /// <param name="saved"></param>
        /// <returns></returns>
        public async Task RemoveAsync(T model, bool saved = true)
        {
            await RemoveAsync(model.Id, saved);
        }

        /// <summary>
        ///  保存
        /// </summary>
        /// <returns></returns>
        public async Task Save()
        {
            await _managementContext.SaveChangesAsync();
        }

        /// <summary>
        ///  根据 id 获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetOneByIdAsync(Guid id)
        {
            return await GetAllAsync().FirstAsync(i => i.Id == id);
        }

        /// <summary>
        ///  获取所有数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAllAsync()
        {
            return _managementContext.Set<T>().Where(i => !i.IsRemove).AsNoTracking();
        }

        // public IQueryable<T> GetAll()
        // {
        //     return _managementContext.Set<T>().Where(i => i.IsRemove == false).AsNoTracking();
        // }

        /// <summary>
        ///  获取数据并排序
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public IQueryable<T> GetAllPageAsync(int pageSize = 10, int pageIndex = 0)
        {
            return GetAllAsync().Skip(pageSize * pageIndex).Take(pageSize);
        }

        /// <summary>
        ///  是否使用排序
        /// </summary>
        /// <param name="asc"></param>
        /// <returns></returns>
        public IQueryable<T> GetAllOrderAsync(bool asc = true)
        {
            var record = GetAllAsync();
            // 创建时间
            record = asc ? record.OrderBy(i => i.CreateDate) : record.OrderByDescending(i => i.CreateDate);
            // 修改时间
            record = asc ? record.OrderBy(i => i.UpdateDate) : record.OrderByDescending(i => i.UpdateDate);
            return record;
        }

        /// <summary>
        ///  获取数据并排序 是否使用降序或顺序
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public IQueryable<T> GetAllByPageOrderAsync(int pageSize = 10, int pageIndex = 0, bool asc = true)
        {
            return GetAllOrderAsync(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }
        public void Dispose()
        {
            _managementContext.Dispose();
        }
    }
}
