﻿using Bloggr.Domain.Interfaces;
using Bloggr.Domain.Models;
using Bloggr.Infrastructure.Services;
using Domain.Abstracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bloggr.Infrastructure.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        public Task<TEntity?> GetById(int id);

        public IQueryable<TEntity> Query();

        public Task<IEnumerable<TEntity>> GetAll();

        public Task<PagedResult<TEntity>> Paginate(IQueryable<TEntity> query, PageModel pageDto);

        public Task<TEntity> Add(TEntity entity);

        public Task<IEnumerable<TEntity>> AddRange(IEnumerable<TEntity> entities);

        public Task<TEntity> Remove(TEntity entity);

        public Task<TEntity?> RemoveById(int id);

        public Task<IEnumerable<TEntity>> RemoveRange(IEnumerable<TEntity> entities);

        public Task<TEntity> Update(TEntity entity);

        public Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> expression);
    }
}
