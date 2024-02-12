using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repositoryBase = repository;
        }

        public void Add(TEntity entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetById(long id)
        {
            return _repositoryBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repositoryBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repositoryBase.Update(obj);
        }
    }
}
