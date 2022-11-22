using System.Collections.Generic;
using System.Linq;

namespace CollectionDemo
{
    public class CarRepository : GenericRepository<Car>
    {
        public CarRepository(ICollection<Car> database) : base(database)
        {
        }
    }
}
