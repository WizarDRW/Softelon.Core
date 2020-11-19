using System.Collections.Generic;
using Softelon.Core.Entities;
using Softelon.Core.Context;
using Dapper;

namespace Softelon.Core.DataAccess
{
    public class DapperRepositoryBase<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private string _conn;
        public DapperRepositoryBase(string conn)
        {
            _conn = conn;
        }

        public TEntity Add(string sql, TEntity entity)
        {
            using (var db = DapperContext.OpenConn(_conn))
            {
                return db.QueryFirstOrDefault<TEntity>(sql, entity);
            }
        }

        public TEntity Update(string sql, TEntity entity)
        {
            using (var db = DapperContext.OpenConn(_conn))
            {
                return db.QueryFirstOrDefault<TEntity>(sql, entity);
            }
        }

        public TEntity Delete(string sql, TEntity entity)
        {
            using (var db = DapperContext.OpenConn(_conn))
            {
                return db.QueryFirstOrDefault<TEntity>(sql, entity);
            }
        }

        public TEntity Get(string sql, DynamicParameters dynamicParameters)
        {
            using (var db = DapperContext.OpenConn(_conn))
            {
                return db.QueryFirstOrDefault<TEntity>(sql, dynamicParameters);
            }
        }

        public IEnumerable<TEntity> GetAll(string sql, DynamicParameters dynamicParameters = null)
        {
            using (var db = DapperContext.OpenConn(_conn))
            {
                return db.Query<TEntity>(sql, dynamicParameters);
            }
        }
    }
}