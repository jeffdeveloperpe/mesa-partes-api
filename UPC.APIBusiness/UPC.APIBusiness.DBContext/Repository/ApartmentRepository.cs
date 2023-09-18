using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DBContext
{
    public class ApartmentRepository : BaseRepository, IApartmentRepository
    {
        public EntityBaseResponse GetApartments(int id)
        {
            var response = new EntityBaseResponse();

            try
            {
                using(var db = GetSqlConnection())
                {
                    var apartments = new List<EntityApartment>();
                    const string sql = "usp_Listar_Departamentos_X_Proyecto";
                    var p = new DynamicParameters();
                    
                    p.Add(name: "@IDPROYECTO", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    apartments = db.Query<EntityApartment>(
                            sql: sql,
                            param: p,
                            commandType: CommandType.StoredProcedure
                        ).ToList();

                    if(apartments.Count > 0 )
                    {
                        var imageRepo = new ImageRepository();
                        foreach(var apa in apartments)
                        {
                            apa.Images = imageRepo.GetImages(apa.IdDepartamento, "A");
                        }

                        response.IsSuccess = true;
                        response.ErrorCode = "0000";
                        response.ErrorMessage = string.Empty;
                        response.Data = apartments;
                    } else
                    {
                        response.IsSuccess = false;
                        response.ErrorCode = "0000";
                        response.ErrorMessage = string.Empty;
                        response.Data = null;
                    }
                }
            } catch (Exception ex) {
                response.IsSuccess = false;
                response.ErrorCode = "0001";
                response.ErrorMessage = ex.Message;
                response.Data = null;
            }

            return response;
        }
    }
}