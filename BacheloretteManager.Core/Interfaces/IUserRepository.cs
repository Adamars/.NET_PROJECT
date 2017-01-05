using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BacheloretteManager.Core.Interfaces
{
    interface IUserRepository
    {
        void Add(User user);
        void Edit(User user);
        void Remove(int userId);
        IEnumerable<User> GetUsers();
        User FindById(int userID);
    }
}
