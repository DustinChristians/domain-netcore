﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CompanyName.ProjectName.Core.Models.Repositories;

namespace CompanyName.ProjectName.Core.Abstractions.Repositories
{
    public interface IBaseRepository<T>
        where T : BaseModel
    {
        Task<bool> ExistsAsync(int id);
        Task<T> GetByIdAsync(int id);
        Task<T> GetByGuidAsync(Guid guid);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);

        Task<int> CountAllAsync();
        Task<int> CountWhereAsync(Expression<Func<T, bool>> predicate);

        Task AddAsync(T entity);
        Task BulkAddAsync(List<T> entities);

        void UpdateAsync(T entity);
        Task BulkUpdateAsync(List<T> entities);

        void DeleteAsync(T entity);
        Task BulkDeleteEntities(List<T> entities);

        Task SaveChangesAsync();
    }
}
