using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    /// <summary>
    /// A datastore simulation
    /// </summary>
    public static class Database
    {
        /// <summary>
        /// A dummy datastore for Student object
        /// </summary>
        public static ICollection<Student> StudentTable { get; set; } = new HashSet<Student>();
        public static ICollection<Car> CarTable { get; set; } = new List<Car>();
    }
}