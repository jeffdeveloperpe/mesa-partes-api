using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext;

public class RolRepository : BaseRepository, IRolRepository
{
  public List<Rol> List()
  {
    var result = new List<Rol>();
    using (var db = GetSqlConnection())
    {
      const string sql = "SELECT * FROM mesa_parte.ROL";
      result = db.Query<Rol>(sql, commandType: CommandType.Text).ToList();
    }
    return result;
  }
}