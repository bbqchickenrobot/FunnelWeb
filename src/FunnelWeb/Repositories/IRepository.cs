﻿using System.Collections.Generic;

namespace FunnelWeb.Repositories
{
    public interface IRepository
    {
        TEntity Get<TEntity>(object id);
        IEnumerable<TEntity> FindAll<TEntity>() where TEntity : class;
        IEnumerable<TEntity> Find<TEntity>(IQuery<TEntity> query) where TEntity : class;
        IEnumerable<TEntity> Find<TEntity>(IQueryWithCount<TEntity> query, int skip, int take, out int totalCount) where TEntity : class;
        TEntity FindFirst<TEntity>(IQuery<TEntity> query) where TEntity : class;
        TEntity FindFirstOrDefault<TEntity>(IQuery<TEntity> query) where TEntity : class;
        void Execute(ICommand command);
        void Add(object entity);
        void Remove(object entity);
    }
}
