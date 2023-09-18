using System.Collections.Generic;
using DBEntity;

namespace DBContext;

public interface IRolRepository
{
  List<Rol> List();
}