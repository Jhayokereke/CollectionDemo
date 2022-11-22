using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class GenericRepository<T> where T : BaseEntity
    {
        private readonly ICollection<T> _db;

        public GenericRepository(ICollection<T> database)
        {
            _db = database;
        }

        public void Add(T item)
        {
            _db.Add(item);
        }

        public T Get(string id)
        {
            return _db.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(string id)
        {
            T itemToDelete = Get(id);
            _db.Remove(itemToDelete);
        }
    }
}
