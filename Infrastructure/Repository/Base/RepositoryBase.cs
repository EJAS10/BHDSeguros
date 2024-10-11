using BHDSeguros.Domain.Entities.Commun;
using BHDSeguros.Domain.Helpers.Date;
using FactBHDSegurosuracion.Domain.Interfaces.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BHDSeguros.Infrastructure.Repository.Base
{
    public class RepositoryBase<T, TContext> : IRepositoryBase<T> where T : Communs, new()
        where TContext : DbContext
    {
        private readonly TContext _dbContext;
        public RepositoryBase(TContext dbContext)
        {
            _dbContext = dbContext;
        }        

        public void Update(T Entity)
        {
            Entity.DateUpdate = DateHelper.GetNow();
            Entity.DateUpdate = DateHelper.GetNow();
            _dbContext.Entry(Entity).State = EntityState.Modified;
            _dbContext.Entry(Entity).Property(x => x.Id).IsModified = false;
            _dbContext.Entry(Entity).Property(x => x.DateCreation).IsModified = false;
            _dbContext.SaveChanges();

        }
        public void Insert(T Entity)
        {
            Entity.DateCreation = DateHelper.GetNow();
            Entity.DateUpdate = DateHelper.GetNow();
            _dbContext.Entry(Entity).State = EntityState.Added;
            _dbContext.SaveChanges();
        }
        public void Deleted(Expression<Func<T, bool>> where)
        {
            _dbContext.Entry(where).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }
    }
}
