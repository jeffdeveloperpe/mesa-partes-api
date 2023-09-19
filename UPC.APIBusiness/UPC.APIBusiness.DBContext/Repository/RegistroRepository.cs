using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DBContext;
using UPC.APIBusiness.DBContext.Interface;
using UPC.APIBusiness.DBEntity.Model;

namespace UPC.APIBusiness.DBContext.Repository;

public class RegistroRepository : BaseRepository, IRegistroRepository
{
  public List<Registro> List()
  {
    var result = new List<Registro>();
    using (var db= GetSqlConnection())
    {
      const string sql = "SELECT * FROM mesa_parte.REGISTRO";
      result = db.Query<Registro>(sql,
        commandType: CommandType.Text).ToList();
    }
    
    return result;
  }

  public Registro Get(int id)
  {
    var result = new Registro();
    using (var db = GetSqlConnection())
    {
      const string sql = "SELECT * FROM mesa_parte.REGISTRO WHERE id = @Id";
      result = db.QueryFirstOrDefault<Registro>(sql, new { Id = id });
    }

    return result;
  }
}