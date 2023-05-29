using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class Repository<T> where T : AEntity
    {
        protected DataContext _context;

        private List<T> Entities => _context.Set<T>();

        /// <summary>
        /// Add a new entity to the repository
        /// </summary>
        /// <param name="entity">the entity to add</param>
        public void Create(T entity) => Entities.Add(entity);

        public T Read(uint id) => Entities.FirstOrDefault(e => e.Id == id);

        public abstract void Update(T entity);

        public void Delete(T entity) => Entities.Remove(entity);

        public async Task Save() => await _context.Save(); 
    }
}
