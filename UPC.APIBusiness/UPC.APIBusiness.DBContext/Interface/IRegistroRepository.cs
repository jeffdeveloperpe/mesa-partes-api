using System.Collections.Generic;
using UPC.APIBusiness.DBEntity.Model;

namespace UPC.APIBusiness.DBContext.Interface;

public interface IRegistroRepository
{
  List<Registro> List();
  Registro Get(int id);
}