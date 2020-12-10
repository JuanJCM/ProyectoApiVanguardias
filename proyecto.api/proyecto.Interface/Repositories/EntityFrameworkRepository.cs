using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using proyecto.Core.Entities;
using proyecto.Core.IRepositories;

namespace proyecto.Infrastructure.Repositories
{
    public class EntityFrameworkRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ProyectoDbContext _ProyectoDbContext;

        public EntityFrameworkRepository(ProyectoDbContext ProyectoDbContext)
        {
            _ProyectoDbContext = ProyectoDbContext;
        }

        public IEnumerable<T> GetAll()
        {
            return _ProyectoDbContext.Set<T>().ToList();
        }

        public IEnumerable<T> Filter(Expression<Func<T, bool>> predicate)
        {
            return _ProyectoDbContext.Set<T>().Where(predicate).ToList();
        }

        public T GetById(int id)
        {
            return _ProyectoDbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public T Add(T entity)
        {
            _ProyectoDbContext.Add(entity);
            _ProyectoDbContext.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            _ProyectoDbContext.Entry(entity).State = EntityState.Modified;
            _ProyectoDbContext.SaveChanges();
            return entity;
        }

        public int SaveChanges()
        {
            return _ProyectoDbContext.SaveChanges();
        }
    }
}