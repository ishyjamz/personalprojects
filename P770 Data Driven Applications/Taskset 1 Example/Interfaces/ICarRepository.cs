using Models;
using System.Collections.Generic;

namespace Interfaces
{
    /// <summary>
    /// Defines a repository for performing basic data access operations on 
    /// objects of type <see cref="Car"/>.
    /// </summary>

    public interface ICarRepository
    {
        /// <summary>
        /// Returns a list of all records of type <see cref="Car"/> in the
        /// data store.
        /// </summary>
        IReadOnlyList<Car> List();

        /// <summary>
        /// Adds a new record of type <see cref="Car"/> to the data store.
        /// </summary>
        void Insert(Car car);
    }
}
