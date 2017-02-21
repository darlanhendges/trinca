using System.Collections.Generic;
using System.Data.Entity;

namespace DAB.Generic
{
    /// <summary>
    /// Implementa os demais métodos da classe
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class GenericAbstractEntity<T> where T : class

    {
        /// <summary>
        /// Implementa o listar
        /// </summary>
        public IEnumerable<T> Listar
        {
            get
            {
                return Base._context.Set<T>();
            }
        }

        /// <summary>
        /// Implementa o adicionar
        /// </summary>
        /// <param name="entity"></param>
        public void Adiciona(T entity)
        {
            Base._context.Entry<T>(entity);
            Base._context.Entry(entity).State = EntityState.Added;
            Base._context.SaveChanges();
        }

        /// <summary>
        /// Implementa o atualizar
        /// </summary>
        /// <param name="entity"></param>
        public void Atualiza(T entity)
        {
            Base._context.Entry(entity).State = EntityState.Modified;
            Base._context.SaveChanges();
        }

        /// <summary>
        /// Implementa o buscar por id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public T BuscaPorID(int _idPesquisa)
        {
            return Base._context.Set<T>().Find(_idPesquisa);
        }

        /// <summary>
        /// Implementa o deletar
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Deleta(T entity)
        {
            Base._context.Entry(entity).State = EntityState.Deleted;
            Base._context.SaveChanges();
        }

    }
}
