using System.Collections.Generic;
using DBEntity;

namespace DBContext
{
    public interface IUserRepository
    {
        List<User> List();
        User Get(int id);
    }
}
