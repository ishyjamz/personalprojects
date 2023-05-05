using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDataAccessModels;
using PresentationModels.Login;

namespace BusinessLogic.GeneralLogic
{
    /// <summary>
    /// contains logic for managing users
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// Performs a get to retrieve a user for the specified aspnetuserid
        /// </summary>
        /// <param name="aspNetUserId"></param>
        /// <returns></returns>
        public PresUser Get(string aspNetUserId)
        {
            using (var context = new CarShareEntities())
            {
                var user = context.Users.Single(c =>
                c.AspNetUserId == aspNetUserId);
                return new PresUser 
                {
                    UserId = user.UserId,
                    Name = user.Name
                };
            }
        }

        /// <summary>
        /// Lists all of the passengers so a driver can select them to add to 
        /// his/her approved list
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<PresUser> List(int userId)
        {
            using (var context = new CarShareEntities())
            {
                var passengersList = context.Users.Select(p =>
                new PresUser
                {
                    UserId = p.UserId,
                    Name = p.Name
                }).Where(p => p.UserId != userId).OrderBy(p => p.Name).ToList();
                return passengersList;
            }
        }
    }
}
