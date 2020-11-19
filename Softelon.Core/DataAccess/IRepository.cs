using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Dapper;
using Softelon.Core.Entities;

namespace Softelon.Core.DataAccess
{
    public interface IRepository<T>
        where T: class, IEntity, new()
    {
        IEnumerable<T> GetAll(string sql, DynamicParameters dynamicParameters);
        T Get(string sql, DynamicParameters dynamicParameters);
        T Add(string sql, T entity);
        T Update(string sql, T entity);
        T Delete(string sql, T entity);
    }
}
