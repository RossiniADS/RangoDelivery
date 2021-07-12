using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly RangoDeliveryContexto RangoDeliveryContexto;

        public BaseRepositorio(RangoDeliveryContexto rangoDeliveryContexto)
        {
            RangoDeliveryContexto = rangoDeliveryContexto; 
        }

        public void Adicionar(TEntity entity)
        {
            RangoDeliveryContexto.Set<TEntity>().Add(entity);
            RangoDeliveryContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            RangoDeliveryContexto.Set<TEntity>().Update(entity);
            RangoDeliveryContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return RangoDeliveryContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return RangoDeliveryContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            RangoDeliveryContexto.Set<TEntity>().Remove(entity);
            RangoDeliveryContexto.SaveChanges();
        }
        public void Dispose()
        {
            RangoDeliveryContexto.Dispose();
        }
    }
}
