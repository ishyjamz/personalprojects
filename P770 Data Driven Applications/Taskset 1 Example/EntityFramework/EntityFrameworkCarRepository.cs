using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Models;

namespace EntityFrameworkRepo
{
    /// <summary>
    /// Repository providing basic data access functions for the
    /// <see cref="Car"/> class, using the Entity Framework to access the
    /// database.
    /// </summary>
    public class EntityFrameworkCarRepository :
        ICarRepository
    {
        // Note that we have to create a new context in every method here. This means we can't re-use
        // contexts which in turn means that some of the built-in optimisations of EF are lost.
        // The alternatives would be to accept a context (which would mean the SaveChanges method could no
        // longer be called safely as we don't know what other changes have been made to the context)
        // or to keep hold of the context, making the entire repository IDisposable (so we can dispose of it when
        // we're done). This would fail to hide the complexity of the data access though (what little there is with EF)
        // - we would have to fundementally understand the Repository from outside of the repository in order
        // to know when to dispose of it. This pretty much amounts to knowing the repository uses EF. In addition,
        // are non-EF repositories would have to implement IDisposable as well - and they'd have nothing to dispose so
        // architecturally this doesn't make much sense.
        // Conclusion: the repository pattern does not fit well with EF.

        /// <summary>
        /// Returns a list of all car records stored in the database.
        /// </summary>
        public IReadOnlyList<Car> List()
        {
            // Simply return the entire contents of the Cars DbSet.
            using (var context = new DDAEntities())
            {
                return context.Cars.ToList();
            }
        }

        /// <summary>
        /// Inserts a new car record into the database.
        /// </summary>
        /// <param name="entity">The car to insert.</param>
        /// <remarks>Does not include any error handling for the case where the
        /// car already exists.</remarks>
        public void Insert(
            Car entity)
        {
            // Add the new car to the context and save.
            using (var context = new DDAEntities())
            {
                context.Cars.Add(entity);
                context.SaveChanges();
            }
        }
    }
}
