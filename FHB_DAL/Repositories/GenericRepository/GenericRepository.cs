using FHB_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_DAL.Repositories.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly DbSet<T> _dbSet;
        public readonly FithubDbContext _fithubDbContext;


        public GenericRepository(FithubDbContext fithubDbContext)
        {
            _fithubDbContext = fithubDbContext;
            _dbSet = _fithubDbContext.Set<T>();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            try
            {
                _fithubDbContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return entity;
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public bool Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                return Delete(entity);
            }
            else
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            try
            {
                _fithubDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }



        public T Update(T entity)
        {
            _dbSet.Update(entity);
            try
            {
                _fithubDbContext.SaveChanges();
            }
            catch
            {

            }
            return entity;
        }

        public void SaveChanges()
        {
            _fithubDbContext.SaveChanges();
        }


    }
}
