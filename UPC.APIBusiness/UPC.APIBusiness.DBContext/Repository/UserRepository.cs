using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext;

public class UserRepository : BaseRepository, IUserRepository
{
  public List<User> List()
  {
    var result = new List<User>();
    using (var db = GetSqlConnection())
    {
      const string sql = "SELECT * FROM mesa_parte.USUARIO";
      result = db.Query<User>(sql,
        commandType: CommandType.Text).ToList();
    }
    return result;
  }

  public User Get(int id)
  {
    var result = new User();
    using (var db = GetSqlConnection())
    {
      const string sql = "SELECT * FROM mesa_parte.USUARIO WHERE id = @Id";
      result = db.QueryFirstOrDefault<User>(sql, new { Id = id });
    }

    return result;
  }
}