using System.Collections.Generic;
using System.Linq;

namespace CollectionDemo
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(ICollection<Student> database) : base(database)
        {
        }
    }
}
